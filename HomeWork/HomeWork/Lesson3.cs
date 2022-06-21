using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson3
    {
        static void Main3(string[] args)
        {
            string name;
            int year;
            string zodiacSign;
            string profession;

            Console.WriteLine("Как вас зовут?");
            name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Какой у вас знак зодиака?");
            zodiacSign = Console.ReadLine();
            Console.WriteLine("Где вы работаете?");
            profession = Console.ReadLine();

            Console.Write($"Вас зовут {name}, вам {year} год, вы {zodiacSign} и работаете {profession}.");
        }
    }
}
