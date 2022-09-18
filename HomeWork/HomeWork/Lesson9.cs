using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson9
    {
        static void Main(string[] args)
        {
            string password= "";
            string keyword = "exit";
            while (true)
            {
                Console.WriteLine("Чтобы выйти из цикла введите слово "+ keyword);
                password = Console.ReadLine();
                if (password == keyword)
                {
                    break;
                }
            }
        }
    }
}

