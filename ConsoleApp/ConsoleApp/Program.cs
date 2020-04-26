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
        static FirstThreadExecutive firstThread;
        static SecondThreadExecutive secondThread;
        static ThirdThreadExecutive thirdThread;

        static void Init()
        {
            firstThread = new FirstThreadExecutive();
            secondThread = new SecondThreadExecutive();
            thirdThread = new ThirdThreadExecutive();
        }

        static void Start()
        {
            firstThread.Execute();
            secondThread.Execute();
            thirdThread.Execute();
        }

        static void Main(string[] args)
        {
            Init();
            Start();
        }
    }
}
