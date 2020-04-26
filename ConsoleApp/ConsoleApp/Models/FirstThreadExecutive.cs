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
    /// Первый исполнительный поток.
    /// </summary>
    public class FirstThreadExecutive: BaseThreadExecutive
    {
        /// <summary>
        /// Для генерации случайных чисел.
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Минимальное значение, клторое может сгенерирвоать рандом.
        /// </summary>
        private readonly int minValue = 1;

        /// <summary>
        /// Максимальное значение, клторое может сгенерирвоать рандом.
        /// </summary>
        private readonly int maxValue = 20;

        /// <summary>
        /// Запускает Поток 1.
        /// </summary>
        public FirstThreadExecutive()
        {
            this.freeqExecute = 1000;
        }

        /// <inheritdoc/>
        public override void Execute()
        {
            int num = random.Next(minValue, maxValue) % maxValue;
            Program.text_1.WriteNum(num);
            Console.WriteLine($"Поток #1 записал в {Program.text_1.FileName} число {num}");
        }
    }
}
