﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практическая_работа_1.Core
{
    internal class ClassSwitch
    {
        static CommandsTask commandsTask = new CommandsTask();
        public void GG(int i)
        {
            switch (i)
            {
                case 1:
                    commandsTask.Task1();
                    break;
                case 2:
                    commandsTask.Task2();
                    break;
                case 3:
                    commandsTask.Task3();
                    break;
                case 4:
                    commandsTask.Task4();
                    break;
                case 5:
                    commandsTask.Task5();
                    break;
                case 6:
                    commandsTask.Task6();
                    break;
                case 7:
                    commandsTask.Task7();
                    break;
                case 8:
                    commandsTask.Task8();
                    break;
                case 9:
                    commandsTask.Task9();
                    break;
                case 10:
                    commandsTask.Task10();
                    break;
                default:
                    Console.WriteLine("Некоректный номер задания");
                    break;
            }

        }
    }
}
