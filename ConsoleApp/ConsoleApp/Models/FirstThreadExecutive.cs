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
        /// Запускает Поток 1.
        /// </summary>
        public FirstThreadExecutive()
        {
            this.freeqExecute = 1000;
        }

        /// <inheritdoc/>
        public override void Execute() => text_1.WriteNum(random.Next());
    }
}
