using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson11
    {
        static void Main11(string[] args)
        {
            Random random = new Random();

            int minNamber = 0;
            int maxNamber = 101;
            int namber = random.Next(minNamber, maxNamber);
            int sum = 0;
            int positiveNumber;
            int multiple1 = 3;
            int multiple2 = 5; 

            Console.WriteLine("Случайное число: "+ namber);

            for (positiveNumber = 0; positiveNumber <= namber; positiveNumber++)
            {
                if ((positiveNumber % multiple1 == 0) || (positiveNumber % multiple2 == 0))
                {
                    sum += positiveNumber;
                }
            }

            Console.WriteLine("Сумма всех чисел кратные "+ multiple1 + " или " + multiple2 + ": " + sum);
        }
    }
}
