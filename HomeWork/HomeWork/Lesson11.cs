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
            Random random = new Random();
            int minNamber = 0;
            int maxNamber = 101;
            int namber = random.Next(minNamber, maxNamber);
            int sum = 0;
            int positiveNumber;
            int multipleThree = 3;
            int multipleFive = 5; 
            Console.WriteLine("Случайное число: "+ namber);

            for (positiveNumber = 0; positiveNumber <= namber; positiveNumber++)
            {
                if ((positiveNumber % multipleThree == 0) || (positiveNumber % multipleFive == 0))
                {
                    sum += positiveNumber;
                }
            }
            Console.WriteLine("Сумма всех чисел кратные 3 или 5: " + sum);
        }
    }
}
