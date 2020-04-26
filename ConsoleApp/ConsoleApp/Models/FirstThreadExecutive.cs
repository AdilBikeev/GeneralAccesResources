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
        /// Файл для записи в него случайных чисел.
        /// </summary>
        FileNum text_1 = new FileNum(nameof(text_1));

        /// <summary>
        /// Запускает Поток 1.
        /// </summary>
        public FirstThreadExecutive()
        {
            this.thread.StartTimer(this.Execute, freeqWExecute);
            this.freeqWExecute = 1000;
        }

        /// <inheritdoc/>
        public override void Execute() => text_1.WriteNum(random.Next());
    }
}
