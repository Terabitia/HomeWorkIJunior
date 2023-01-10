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
                string userOutInput = "";
                float currencyCount;

                Console.WriteLine("Добро пожаловать в обменник влют. У нас вы можете обменять доллары в рубли,рубли в доллары, евро в рубли, рубли в евро, евро в доллары, доллары в евро.");

                Console.Write("Ведите баланс рублей ");
                rub = Convert.ToSingle(Console.ReadLine());
                Console.Write("Ведите баланс долларов ");
                usd = Convert.ToSingle(Console.ReadLine());
                Console.Write("Ведите баланс евро ");
                eur = Convert.ToSingle(Console.ReadLine());

                while (userOutInput != "1")
                {


                    Console.WriteLine("1 - обменять рубли на доллары");
                    Console.WriteLine("2 - обменять доллары на рубли");
                    Console.WriteLine("3 - обменять рубли на евро");
                    Console.WriteLine("4 - обменять евро на рубли");
                    Console.WriteLine("5 - обменять доллары на евро");
                    Console.WriteLine("6 - обменять евро на доллары");


                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "1":
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
                        case "2":
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
                        case "3":
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
                        case "4":
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
                        case "5":
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
                        case "6":
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
                    }
                    Console.WriteLine("Ваш баланс - " + rub + " рублей, " + usd + " долларов и " + eur + " евро.");

                    Console.WriteLine("1 - Выйти изобмена");
                    Console.WriteLine("2 - Продолжить обмен");

                    userOutInput = Console.ReadLine();
                }
            }
        }
 }
