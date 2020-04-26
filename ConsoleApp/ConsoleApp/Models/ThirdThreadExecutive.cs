using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Interfaces;
using ConsoleApp.Hellpers;

namespace ConsoleApp.Models
{
    /// <summary>
    /// Третий исполнительный поток.
    /// </summary>
    class ThirdThreadExecutive : BaseThreadExecutive
    {
        public ThirdThreadExecutive()
        {
            this.freeqExecute = 0;
        }

        /// <summary>
        /// Запоминает сумму последних двух чисел из файла 2 и записывает эти числа в файл 1.
        /// </summary>
        public override void Execute()
        {
            if(Program.text_2.CountNewRow > 1)
            {
                var nums = Program.text_2.ReadTwoLastNum();

                if (nums.Item1 != 0 && nums.Item2 != 0)
                {
                    int sum = nums.Item1 + nums.Item2;
                    Program.text_1.WriteNum(sum);
                    Console.WriteLine($"Поток #3 записал в {Program.text_1.FileName} сумму двух последних цифр из файла {Program.text_2.FileName} {nums.Item1} + {nums.Item2} = {sum}");
                }
            }
        }
    }
}
