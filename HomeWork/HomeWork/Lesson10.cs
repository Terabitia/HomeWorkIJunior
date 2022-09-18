using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson10
    {
        static void Main10(string[] args)
        {
            int minNumber = 5;
            int maxNumber = 100;
            int step = 7;
            int subsequence;

            for (subsequence = minNumber; subsequence < maxNumber; subsequence += step)
            {
                Console.Write(subsequence + " ");
            }
        }
    }
}
