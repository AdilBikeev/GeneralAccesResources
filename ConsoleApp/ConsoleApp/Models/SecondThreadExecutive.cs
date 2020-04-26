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
        /// <summary>
        /// Файл 2.
        /// </summary>
        FileNum text_2 = new FileNum(nameof(text_2));

        public SecondThreadExecutive()
        {
            this.freeqExecute = 500;
        }

        /// <summary>
        /// Считывает последние 2 цифры с файла 1 и запиисывает их сумму в конец файла 2.
        /// </summary>
        public override void Execute()
        {
            int num = this.text_1.ReadTwoLastNum();
            this.text_2.WriteNum(num);
        }
    }
}
