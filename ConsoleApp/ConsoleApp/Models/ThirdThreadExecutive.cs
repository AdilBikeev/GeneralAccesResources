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
    /// Третий исполнительный поток.
    /// </summary>
    class ThirdThreadExecutive : BaseThreadExecutive
    {
        /// <summary>
        /// Файл 2.
        /// </summary>
        FileNum text_2 = new FileNum(nameof(text_2));

        public ThirdThreadExecutive()
        {
            this.freeqExecute = 1500;
        }

        /// <summary>
        /// Запоминает сумму последних двух чисел из файла 2 и записывает эти числа в файл 1.
        /// </summary>
        public override void Execute()
        {
            int num = this.text_2.ReadTwoLastNum();
            this.text_1.WriteNum(num);
        }
    }
}