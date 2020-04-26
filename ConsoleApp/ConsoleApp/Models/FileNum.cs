using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class FileNum: IFileOperation
    {
        private readonly string Extension = "txt";

        private Mutex mutex = new Mutex();

        /// <summary>
        /// Кол-во новых строк, после чтения из них двух последних цифр.
        /// Требуется для обнуления и использования в качестве сигнала записи в следующий файл.
        /// </summary>
        public int CountNewRow { get; private set; } = 0;

        /// <summary>
        /// Имя файла.
        /// </summary>
        public string FileName { get; private set; }

        /// <summary>
        /// Полный путь к файлу.
        /// </summary>
        public string FullPath 
        { 
            get => Path.Combine(Directory.GetCurrentDirectory(), this.FileName);
            private set => new NotImplementedException(); 
        }

        /// <summary>
        /// Инициализация файла.
        /// </summary>
        /// <param name="fileName">Имя файла.</param>
        public FileNum(string fileName)
        {
            this.FileName = $"{fileName}.{this.Extension}";
        }

        /// <inheritdoc/>
        public void WriteNum(int num)
        {
            try
            {
                using (FileStream fs = File.Open(this.FullPath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
                {
                    byte[] info = new UTF8Encoding().GetBytes(num.ToString() + "\n");
                    fs.Write(info, 0, info.Length);
                }
                
                this.CountNewRow++;
            }
            catch (Exception exc)
            {
                Console.WriteLine($"WriteNum Exception[{Task.CompletedTask.Id}]: {exc.Message}");
            }
        }

        /// <inheritdoc/>
        public (int, int) ReadTwoLastNum()
        {
            int last = 0, preLast = last;

            try
            {
                /// Открываем файл с возможностью одновременного доступа нескольких потоков
                using (FileStream fs = File.Open(this.FullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    byte[] info = new byte[fs.Length];
                    fs.Read(info, 0, info.Length);
                    string[] rowsFromFile = Encoding.Default.GetString(info).Trim().Split('\n');

                    int lastIndex = rowsFromFile.Length;
                    last = int.Parse(rowsFromFile[--lastIndex]);
                    preLast = int.Parse(rowsFromFile[--lastIndex]);

                    this.CountNewRow = 0;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine($"ReadTwoLastNum Exception[{Task.CurrentId}]: {exc.Message}");
            }

            return (last, preLast);
        }
    }
}
