using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson13
    {
        static void Main(string[] args)
        {
            const string NameInputCommand = "1";
            const string YearInputCommand = "2";
            const string PasswordInputCommand = "3";
            const string LoginPasswordInputCommand = "4";
            const string ExitInputCommand = "5";

            string name = "";
            int year = 0;
            string loginPassword = "";
            string userInput;
            string userInputLogin;
            bool isMenu = true;

            Console.WriteLine("Добро пожаловать в наш закрытый компьютерный клуб.");
            
            while (isMenu)
            {
                Console.WriteLine(NameInputCommand + " - Ввести ваше имя.");
                Console.WriteLine(YearInputCommand + " - Ввести ваш возраст.");
                Console.WriteLine(PasswordInputCommand + " - Ввести ваш пароль.");
                Console.WriteLine(LoginPasswordInputCommand + " - Ввести ваш пароль для просмотра информации.");
                Console.WriteLine(ExitInputCommand + " - Выход.");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case NameInputCommand:
                        Console.WriteLine("Как вас зовут?");
                        name = Console.ReadLine();
                        break;
                    case YearInputCommand:
                        Console.WriteLine("Уточните ваш возраст: ");
                        year = Convert.ToInt32(Console.ReadLine());
                        break;
                    case PasswordInputCommand:
                        Console.WriteLine("Придумайте ваш личный пароль:");
                        loginPassword = Console.ReadLine();
                        break;
                    case LoginPasswordInputCommand:
                        Console.WriteLine("Введите ваш пароль для просмотра информации: ");
                        userInputLogin = Console.ReadLine();
                        
                        if (userInputLogin == loginPassword)
                        {
                            Console.WriteLine("Ваше имя " + name + " ,вам " + year + " лет." );
                        }
                        else
                        {
                            Console.WriteLine("Пароль неверный.");
                        }
                        break;
                    case ExitInputCommand:
                        isMenu = false;
                        break;
                    default:
                        Console.WriteLine("Нет такого пункта в меню");
                        break;
                }
            }
        }
    }
}