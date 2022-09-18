using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson8
    {
        static void Main(string[] args)
        {
            string message;
            int repeats;

            Console.WriteLine("Введите ваше сообшение:");
            message = Console.ReadLine();
            Console.WriteLine("Введите кол-во повторений вашего сообщения");
            repeats = Convert.ToInt32(Console.ReadLine());

            while (repeats-- > 0)
            {
                Console.WriteLine(message); 

            }

        }
    }
}
