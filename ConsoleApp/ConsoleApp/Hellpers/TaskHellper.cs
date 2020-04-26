﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ConsoleApp.Hellpers
{
    public class TaskHellper
    {
        private Action TargetMethod { get; set; }

        /// <summary>
        /// Запускает метод с периодичностью.
        /// </summary>
        /// <param name="func">Функция дял выполняния.</param>
        /// <param name="ms">Период перезапуска метода в мс.</param>
        /// <returns></returns>
        public void StartTimer(Action func, int ms)
        {
            TargetMethod = func;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, ms);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e) => this.TargetMethod();
    }
}
