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
            float TransferCurrency;

            Console.WriteLine("Введите сколько у вас RUB:");
            RUB=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите сколько у вас USD:");
            USD =Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Введите сколько у вас JPY:");
            JPY =Convert.ToSingle(Console.ReadLine());

            while (password != keyword)
            {
                Console.WriteLine("Из какой валюты вы собираетесь конвертировать?" +
                    "\nРубли - " + keyRub + ", Доллары - " + keyUsd + ", Йены - " + keyJpy + ":");
                keyOneCurrency = Console.ReadLine();
                Console.WriteLine("В какаую валюту вы собираетесь конвертировать?" +
                    "\nРубли - " + keyRub + ", Доллары - " + keyUsd + ", Йены - " + keyJpy + ":");
                keyTwoCurrency = Console.ReadLine();
                Console.WriteLine("Сколько вы хотите перевести?");
                TransferCurrency = Convert.ToSingle(Console.ReadLine());

                if (keyOneCurrency != keyTwoCurrency)
                {
                    if (keyOneCurrency == keyRub)
                    {
                        if (keyTwoCurrency == keyUsd)
                        {
                            RUB -= TransferCurrency;
                            USD += TransferCurrency * RubUsd;
                        }
                        else if (keyTwoCurrency == keyJpy)
                        {
                            RUB -= TransferCurrency;
                            JPY += TransferCurrency * RubJpy;
                        }
                    }
                    else if (keyOneCurrency == keyUsd)

                    {
                        if (keyTwoCurrency == keyRub)
                        {
                            USD -= TransferCurrency;
                            RUB += TransferCurrency / RubUsd;

                        }
                        else if (keyTwoCurrency == keyJpy)
                        {
                            USD -= TransferCurrency;
                            JPY += TransferCurrency / JpyUsd;
                        }
                    }
                    else if (keyOneCurrency == keyJpy)

                    {
                        if (keyTwoCurrency == keyUsd)
                        {
                            JPY -= TransferCurrency;
                            USD += TransferCurrency * JpyUsd;
                        }
                        else if (keyTwoCurrency == keyRub)
                        {
                            JPY -= TransferCurrency;
                            RUB += TransferCurrency / RubJpy;
                        }
                    }

                }
                Console.WriteLine($"После обмена валют у вас осталось {keyRub}={RUB}, {keyUsd}={USD}, {keyJpy}={JPY}");
                Console.WriteLine("Если хотите завершить обмен введитете: " + keyword);
                password = Console.ReadLine();
            }
        }
    }
}
