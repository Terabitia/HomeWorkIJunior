using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson6
    {
        static void Main6(string[] args)
        {
            int myGold;
            int crystals;
            int crystalPrice = 10;

            Console.Write("Введите сколько у вас золота: ");
            myGold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Цена кристала - {crystalPrice}. Сколько вы хотите купить?");
            crystals = Convert.ToInt32(Console.ReadLine());

            myGold -= crystals * crystalPrice;

            Console.WriteLine($"У вас {crystals} кристалов, и {myGold} золота");
        }
    }
}
