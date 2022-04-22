using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Task1
{
    internal static class Demo
    {

        public static void TaskDemo()
        {
            ICoder aCoder = new ACoder();

            ICoder bCoder = new BCoder();

            string text = "(ABC abc XYZ xyz АБВ абв ЭЮЯ эюя)";

            string encodingText = aCoder.Encode(text);

            Console.WriteLine("Тест класса ACoder");

            Console.WriteLine("Исходный текст");

            Console.WriteLine();

            Console.WriteLine(text);

            Console.WriteLine();

            Console.WriteLine("Зашифрованный текст");

            Console.WriteLine();

            Console.WriteLine(encodingText);

            Console.WriteLine();

            string decodingText = aCoder.Decode(encodingText);

            Console.WriteLine("Расшифрованный текст");

            Console.WriteLine();

            Console.WriteLine(decodingText);

            Console.WriteLine();

            text = @"Программист звонит в библиотеку.
— Здравствуйте, Катю можно?
— Она в архиве.
— Разархивируйте ее пожалуйста.Она мне срочно нужна!";

            encodingText = bCoder.Encode(text);

            Console.WriteLine("Тест класса BCoder");

            Console.WriteLine("Исходный текст");

            Console.WriteLine();

            Console.WriteLine(text);

            Console.WriteLine();

            Console.WriteLine("Зашифрованный текст");

            Console.WriteLine();

            Console.WriteLine(encodingText);

            Console.WriteLine();

            decodingText = bCoder.Decode(encodingText);

            Console.WriteLine("Расшифрованный текст");

            Console.WriteLine();

            Console.WriteLine(decodingText);

            Console.WriteLine();

            Console.WriteLine($"To continue press any key...");

            Console.ReadKey();
        }
    }
}
