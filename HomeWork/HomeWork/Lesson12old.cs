using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson12old
    {
        static void Main12old(string[] args)
        {
            float rub;
            float usd;
            float eur;
            float rubUsd = 0.016F;
            float usdEur = 0.9F;
            float eurRub = 67.77F;
            string currencyIn;
            string currencyOut;
            string currencyRub = "RUB";
            string currencyUsd = "USD";
            string currencyEur = "EUR";
            string password = "";
            string keyword = "exit";

            Console.WriteLine("Это ковертор валют. Введите сколько у вас рублей:");
            rub=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите сколько у вас долларов:");
            usd =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите сколько у вас евро:");
            eur = Convert.ToSingle(Console.ReadLine());

            while (password != keyword)
            {
                Console.WriteLine($"У вас на счету: {rub} RUB, {usd} USD, {eur} EUR.");
                Console.WriteLine($"Коэфициенты валют: RUB-USD {rubUsd}, USD-EUR {usdEur}, EUR-RUB {eurRub}.");
                Console.WriteLine($"Введите из какой валюты вы коверторуете: RUB, USD, EUR.");
                currencyOut = Console.ReadLine();
                Console.WriteLine($"Введите в какую валюту вы коверторуете: RUB, USD, EUR.");
                currencyIn = Console.ReadLine();
                
                
                
                Console.WriteLine("Чтобы выйти из ковертора введите слово " + keyword+ ", а чтобы продолжить нажмите Enter");
                password = Console.ReadLine();
            }

        }
    }
}
