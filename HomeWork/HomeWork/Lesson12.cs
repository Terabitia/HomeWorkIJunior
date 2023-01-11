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
                bool inExchange = true;
                float currencyCount;
                const string RubToUsdInput = "1";
                const string UsdToRubInput = "2";
                const string RubToEurInput = "3";
                const string EurToRubInput = "4";
                const string UsdToEurInput = "5";
                const string EurToUsdInput = "6";
                const string UserOutInput = "7";
            
                Console.WriteLine("Добро пожаловать в обменник влют. У нас вы можете обменять доллары в рубли,рубли в доллары, евро в рубли, рубли в евро, евро в доллары, доллары в евро.");
                Console.Write("Ведите баланс рублей ");
                rub = Convert.ToSingle(Console.ReadLine());
                Console.Write("Ведите баланс долларов ");
                usd = Convert.ToSingle(Console.ReadLine());
                Console.Write("Ведите баланс евро ");
                eur = Convert.ToSingle(Console.ReadLine());

                while (inExchange)
                {
                    Console.WriteLine(RubToUsdInput + " - обменять рубли на доллары");
                    Console.WriteLine(UsdToRubInput + " - обменять доллары на рубли");
                    Console.WriteLine(RubToEurInput + " - обменять рубли на евро");
                    Console.WriteLine(EurToRubInput + " - обменять евро на рубли");
                    Console.WriteLine(UsdToEurInput + " - обменять доллары на евро");
                    Console.WriteLine(EurToUsdInput + " - обменять евро на доллары");
                    Console.WriteLine(UserOutInput + " - закончить обмен");
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case RubToUsdInput:
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
                        case UsdToRubInput:
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
                        case RubToEurInput:
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
                        case EurToRubInput:
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
                        case UsdToEurInput:
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
                        case EurToUsdInput:
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
                        case UserOutInput:
                            inExchange = false;
                        break;
                    }

                    Console.WriteLine("Ваш баланс - " + rub + " рублей, " + usd + " долларов и " + eur + " евро.");
                }
            }
        }
 }
