﻿using System;
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
        /// <summary>
        /// Файл 2.
        /// </summary>
        FileNum text_2 = new FileNum(nameof(text_2));

        public SecondThreadExecutive()
        {
            this.freeqExecute = 100;
        }

        /// <summary>
        /// Считывает последние 2 цифры с файла 1 и запиисывает их сумму в конец файла 2.
        /// </summary>
        public override void Execute()
        {
            var nums = this.text_1.ReadTwoLastNum();

            if(nums.Item1 != 0 && nums.Item2 != 0)
            {
                int sum = nums.Item1 + nums.Item2;
                this.text_2.WriteNum(sum);
                Console.WriteLine($"Поток #2 записал в {this.text_2.FileName} сумму двух последних цифр из файла {this.text_1.FileName} {nums.Item1} + {nums.Item2} = {sum}");
            }
        }
    }
}
