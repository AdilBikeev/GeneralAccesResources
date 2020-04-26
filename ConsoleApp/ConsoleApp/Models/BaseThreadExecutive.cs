using ConsoleApp.Hellpers;
using ConsoleApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    /// <summary>
    /// Базовы класс для всех потоков-исполнителей.
    /// </summary>
    public abstract class BaseThreadExecutive : IThreadOperation
    {
        /// <summary>
        /// Поток.
        /// </summary>
        protected TaskHellper thread = new TaskHellper();

        /// <summary>
        /// Частота запуска метода Execute.
        /// </summary>
        protected int freeqExecute;

        /// <summary>
        /// Запускает работу потока.
        /// </summary>
        public void StartThread() => this.thread.StartTimer(this.Execute, this.freeqExecute);

        /// <inheritdoc/>
        public abstract void Execute();
    }
}
