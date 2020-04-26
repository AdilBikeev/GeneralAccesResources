using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Interfaces
{
    /// <summary>
    /// Операции с файлом.
    /// </summary>
    public interface IFileOperation
    {
        /// <summary>
        /// Записывает число в файл.
        /// </summary>
        /// <param name="num"></param>
        void WriteNum(int num);

        /// <summary>
        /// Считывает последнии 2 цифры в файле.
        /// </summary>
        /// <returns>Возвращает сумму считанных цифр.</returns>
        int ReadTwoLastNum();
    }
}
