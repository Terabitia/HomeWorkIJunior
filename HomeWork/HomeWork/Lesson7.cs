﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson7
    {
        static void Main(string[] args)
        {
            int numberPeople;
            int receptionTime = 10;
            int waitingMinutes;
            int waitingHours;

            Console.Write("Введите кол-во людей в очереди: ");
            numberPeople = Convert.ToInt32(Console.ReadLine());

            waitingMinutes = numberPeople * receptionTime;
            waitingHours = waitingMinutes / 60;
            waitingMinutes %= 60;

            Console.WriteLine("Вы должны отстоять в очереди " + waitingHours + " часа и " + waitingMinutes + " минут.");
        }
    }
}
