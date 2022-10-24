using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson12
    {
        static void Main(string[] args)
        {
            float RUB;
            float USD;
            float JPY;
            float RubUsd=0.016F;
            float RubJpy=2.40F;
            float JpyUsd=0.0067F;
            string password = "";
            string keyword = "exit";
            string keyRub = "RUB";
            string keyUsd = "USD";
            string keyJpy = "JPY";
            string keyOneCurrency;
            string keyTwoCurrency;

            Console.WriteLine("Введите сколько у вас RUB:");
            RUB=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько у вас USD:");
            USD =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сколько у вас JPY:");
            JPY =Convert.ToInt32(Console.ReadLine());

            while (password != keyword)
            {
                Console.WriteLine("Из какой валюты вы собираетесь конвертировать?\nРубли - RUB, Доллары - USD, Йены - JPY:");
                keyOneCurrency = Console.ReadLine();
                Console.WriteLine("В какаую валюту вы собираетесь конвертировать?\nРубли - RUB, Доллары - USD, Йены - JPY:");
                keyTwoCurrency = Console.ReadLine();



                Console.WriteLine("Если хотите завершить обмен введитете: " + keyword);
                password = Console.ReadLine();
            }


        }


    }
}
