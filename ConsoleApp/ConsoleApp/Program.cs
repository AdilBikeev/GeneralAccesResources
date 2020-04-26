using ConsoleApp.Models;
using ConsoleApp.Hellpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        /// <summary>
        /// Периодичность выполнения дейсвтий потоков с файлами.
        /// </summary>
        int timerOperation = 1000;

        /// <summary>
        /// Файл 1.
        /// </summary>
        FileNum text_1 = new FileNum(nameof(text_1));

        /// <summary>
        /// Файл 2.
        /// </summary>
        FileNum text_2 = new FileNum(nameof(text_2));

        /// <summary>
        /// Объект для синхронизации потоков.
        /// </summary>
        /// static Mutex mutex = new Mutex();

        void Main(string[] args)
        {
        }
    }
}
