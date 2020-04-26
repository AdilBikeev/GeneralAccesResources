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
        static List<BaseThreadExecutive> threads;

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
