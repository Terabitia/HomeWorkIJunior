using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson5
    {
        static void Main5(string[] args)
        {
            string firstName = "Петров";
            string lastName = "Роман";
            string swapName;

            Console.WriteLine($"Ваше имя {firstName}, ваша фамилия {lastName}.");

            swapName = firstName;
            firstName = lastName;
            lastName = swapName;

            Console.WriteLine($"Ваше имя {firstName}, ваша фамилия {lastName}.");
        }
    }
}
