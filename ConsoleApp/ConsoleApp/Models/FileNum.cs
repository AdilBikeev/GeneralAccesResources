using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public class FileNum: IFileOperation
    {
        /// <summary>
        /// Имя файла.
        /// </summary>
        private string FileName { get; set; }

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
            this.FileName = fileName;
        }

        /// <inheritdoc/>
        public void WriteNum(int num)
        {

            try
            {
                using (FileStream fs = File.Open(this.FullPath, FileMode.Append, FileAccess.Write, FileShare.Write))
                {
                    byte[] info = new UTF8Encoding().GetBytes(num.ToString());
                    fs.Write(info, 0, info.Length);
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine($"WriteNum Exception[{Task.CurrentId}]: {exc.Message}");
            }
        }

        /// <inheritdoc/>
        public int ReadTwoLastNum()
        {
            int last = 0, preLast = last;

            try
            {
                /// Открываем файл с возможностью одновременного доступа нескольких потоков
                using (FileStream fs = File.Open(this.FullPath, FileMode.Open, FileAccess.Read, FileShare.Write))
                {
                    byte[] info = new byte[fs.Length];
                    fs.Read(info, 0, info.Length);
                    string[] rowsFromFile = Encoding.Default.GetString(info).Split('\n');

                    /// Если в файле есть хотяб 2 числа
                    if (rowsFromFile.Length > 1)
                    {
                        int lastIndex = rowsFromFile.Length;
                        last = int.Parse(rowsFromFile[--lastIndex]);
                        preLast = int.Parse(rowsFromFile[--lastIndex]);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine($"ReadTwoLastNum Exception[{Task.CurrentId}]: {exc.Message}");
            }

            return last + preLast;
        }
    }
}
