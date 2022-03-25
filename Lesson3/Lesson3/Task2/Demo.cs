using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Task2
{
    internal class Demo
    {
        public static void TaskDemo()
        {
            Console.Clear();

            Console.WriteLine("Переворачиваем слово \"Афроамериканец\" при помощи длинного метода с циклом");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(Task2.StringTurner.StringReverseWithCycle("Афроамериканец"));

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            Console.WriteLine("Переворачиваем слово \"Синхроциклотрон\" при помощи короткого метода в одну строку");

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine(Task2.StringTurner.StringReverse("Синхроциклотрон"));

            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();

            Console.WriteLine($"To continue press any key...");

            Console.ReadKey();
        }
    }
}
