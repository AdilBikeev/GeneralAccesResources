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
    public static class Program
    {
        static List<BaseThreadExecutive> threads;

        /// <summary>
        /// Файл 1.
        /// </summary>
        public static FileNum text_1 = new FileNum(nameof(text_1));

        /// <summary>
        /// Файл 2.
        /// </summary>
        public static FileNum text_2 = new FileNum(nameof(text_2));

        static void Init()
        {
            threads = new List<BaseThreadExecutive>()
            {
                new ThirdThreadExecutive(),
                new SecondThreadExecutive(),
                new FirstThreadExecutive()
            };
        }

        static void Start()
        {
            foreach (var thread in threads)
            {
               thread.StartThread();
            }
        }

        static void Main(string[] args)
        {
            Init();
            Start();

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {

            }
        }
    }
}
