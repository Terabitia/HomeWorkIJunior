using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
        internal class Lesson12
        {
            static void Main12(string[] args)
            {
                const string RubToUsdInputCommand = "1";
                const string UsdToRubInputCommand = "2";
                const string RubToEurInputCommand = "3";
                const string EurToRubInputCommand = "4";
                const string UsdToEurInputCommand = "5";
                const string EurToUsdInputCommand = "6";
                const string UserOutInputCommand = "7";

                int rubToUsd = 64;
                int usdToRub = 66;
                float eurToUsd = 1.2F;
                float usdToEur = 1.4F;
                int rubToEur = 76;
                int eurToRub = 78;
                float rub;
                float usd;
                float eur;
                string userInput;
                bool isExchange = true;
                float currencyCount;
                
            
                Console.WriteLine("Добро пожаловать в обменник влют. У нас вы можете обменять доллары в рубли,рубли в доллары, евро в рубли, рубли в евро, евро в доллары, доллары в евро.");
                Console.Write("Ведите баланс рублей ");
                rub = Convert.ToSingle(Console.ReadLine());
                Console.Write("Ведите баланс долларов ");
                usd = Convert.ToSingle(Console.ReadLine());
                Console.Write("Ведите баланс евро ");
                eur = Convert.ToSingle(Console.ReadLine());

                while (isExchange)
                {
                    Console.WriteLine(RubToUsdInputCommand + " - обменять рубли на доллары");
                    Console.WriteLine(UsdToRubInputCommand + " - обменять доллары на рубли");
                    Console.WriteLine(RubToEurInputCommand + " - обменять рубли на евро");
                    Console.WriteLine(EurToRubInputCommand + " - обменять евро на рубли");
                    Console.WriteLine(UsdToEurInputCommand + " - обменять доллары на евро");
                    Console.WriteLine(EurToUsdInputCommand + " - обменять евро на доллары");
                    Console.WriteLine(UserOutInputCommand + " - закончить обмен");
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case RubToUsdInputCommand:
                            Console.WriteLine("Обмен рублей на доллары");
                            Console.Write("Сколько вы хотите обменять:");
                            currencyCount = Convert.ToSingle(Console.ReadLine());

                            if (rub >= currencyCount)
                            {
                                rub -= currencyCount;
                                usd += currencyCount / rubToUsd;
                            }
                            else
                            {
                                Console.WriteLine("Недупустимое кол-во рублей");
                            }
                            break;
                        case UsdToRubInputCommand:
                            Console.WriteLine("Обмен долларов на рубли.");
                            Console.Write("Сколько вы хотете обменять:");
                            currencyCount = Convert.ToSingle(Console.ReadLine());

                            if (usd >= currencyCount)
                            {
                                usd -= currencyCount;
                                rub += currencyCount * usdToRub;
                            }
                            else
                            {
                                Console.WriteLine("Недупустимое кол-во долларов");
                            }
                            break;
                        case RubToEurInputCommand:
                            Console.WriteLine("Обмен рублей на евро");
                            Console.Write("Сколько вы хотите обменять:");
                            currencyCount = Convert.ToSingle(Console.ReadLine());

                            if (rub >= currencyCount)
                            {
                                rub -= currencyCount;
                                eur += currencyCount / rubToEur;
                            }
                            else
                            {
                                Console.WriteLine("Недупустимое кол-во рублей");
                            }
                            break;
                        case EurToRubInputCommand:
                            Console.WriteLine("Обмен евро на рубли.");
                            Console.Write("Сколько вы хотете обменять:");
                            currencyCount = Convert.ToSingle(Console.ReadLine());

                            if (eur >= currencyCount)
                            {
                                eur -= currencyCount;
                                rub += currencyCount * eurToRub;
                            }
                            else
                            {
                                Console.WriteLine("Недупустимое кол-во евро");
                            }
                            break;
                        case UsdToEurInputCommand:
                            Console.WriteLine("Обмен долларов на евро");
                            Console.Write("Сколько вы хотите обменять:");
                            currencyCount = Convert.ToSingle(Console.ReadLine());

                            if (usd >= currencyCount)
                            {
                                usd -= currencyCount;
                                eur += currencyCount / usdToEur;
                            }
                            else
                            {
                                Console.WriteLine("Недупустимое кол-во долларов");
                            }
                            break;
                        case EurToUsdInputCommand:
                            Console.WriteLine("Обмен евро на доллары.");
                            Console.Write("Сколько вы хотете обменять:");
                            currencyCount = Convert.ToSingle(Console.ReadLine());

                            if (eur >= currencyCount)
                            {
                                eur -= currencyCount;
                                usd += currencyCount * eurToUsd;
                            }
                            else
                            {
                                Console.WriteLine("Недупустимое кол-во евро");
                            }
                            break;
                        case UserOutInputCommand:
                            isExchange = false;
                            break;
                    }

                    Console.WriteLine("Ваш баланс - " + rub + " рублей, " + usd + " долларов и " + eur + " евро.");
                }
            }
        }
 }
