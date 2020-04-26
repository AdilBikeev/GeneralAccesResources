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
    /// Второй исполнительный поток.
    /// </summary>
    public class SecondThreadExecutive : BaseThreadExecutive
    {
        public SecondThreadExecutive()
        {
            this.freeqExecute = 0;
        }

        /// <summary>
        /// Считывает последние 2 цифры с файла 1 и запиисывает их сумму в конец файла 2.
        /// </summary>
        public override void Execute()
        {
            if(Program.text_1.CountNewRow > 1)
            {
                var nums = Program.text_1.ReadTwoLastNum();

                if(nums.Item1 != 0 && nums.Item2 != 0)
                {
                    int sum = nums.Item1 + nums.Item2;
                    Program.text_2.WriteNum(sum);
                    Console.WriteLine($"Поток #2 записал в {Program.text_2.FileName} сумму двух последних цифр из файла {Program.text_1.FileName} {nums.Item1} + {nums.Item2} = {sum}");
                }
            }
        }
    }
}
