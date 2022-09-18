using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson11
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int namber = rand.Next(0, 101);
            int sum=0;
            int positiveNumber;
            Console.WriteLine("Случайное число: "+ namber);

            for (positiveNumber = 0; positiveNumber <= namber; positiveNumber++)
            {
                if ((positiveNumber % 3 == 0) || (positiveNumber % 5 == 0))
                {
                    sum += positiveNumber;
                }
            }
            Console.WriteLine("Сумма всех чисел кратные 3 или 5: " + sum);
        }
    }
}
