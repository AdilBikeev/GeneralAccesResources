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
        /// <param name="num">Число, которое нужно записать в файл.</param>
        void WriteNum(int num);

        /// <summary>
        /// Считывает последнии 2 цифры в файле.
        /// </summary>
        /// <returns>Возвращает 2 последнии цифры.</returns>
        (int, int) ReadTwoLastNum();
    }
}
