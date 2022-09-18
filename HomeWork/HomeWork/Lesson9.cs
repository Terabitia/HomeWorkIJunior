using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson9
    {
        static void Main9(string[] args)
        {
            string password= "";
            string keyword = "exit";

            while (password != keyword)
            {
                Console.WriteLine("Чтобы выйти из цикла введите слово "+ keyword);
                password = Console.ReadLine();
            }
        }
    }
}

