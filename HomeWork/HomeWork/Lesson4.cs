using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Lesson4
    {
        static void Main(string[] args)
        {
            int numberOfPictures = 52;
            int numberInRow = 3;
            int completedRows;
            int extraPictures;

            completedRows = numberOfPictures / numberInRow;
            extraPictures = numberOfPictures % numberInRow;

            Console.WriteLine($"В альбоме {numberOfPictures} картинки, по {numberInRow} в каждом ряду.");
            Console.WriteLine($"Полностью занятых рядов {completedRows}. Картинок сверх меры {extraPictures}.");
        }
    }
}
