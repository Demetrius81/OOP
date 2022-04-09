using System;

namespace Lesson5
{
    /// <summary>
    /// Демонстрационный класс
    /// </summary>
    public class Demo
    {
        /*
        V Протестировать на простом примере.
        */

        /// <summary>
        /// Тестовый метод для рациональных чисел
        /// </summary>
        public static void TestFractions()
        {
            Console.WriteLine("Тестовый пример класса рациональных чисел");

            Console.WriteLine();

            var f1 = new Fractions(81, 7);

            var f2 = new Fractions(20, 3);

            Console.WriteLine("Создали 2 рациональных числа");

            Console.WriteLine(f1.ToString());

            Console.WriteLine(f2.ToString());

            Console.WriteLine("Для продолжения нажмите любую клавишу...");

            Console.ReadKey();

            Console.Write($"Сравнение рациональных чисел:\n" +
                $"f1 == f2){f1 == f2}\n" +
                $"f1 != f2){f1 != f2}\n" +
                $"f1 < f2){f1 < f2}\n" +
                $"f1 > f2){f1 > f2}\n" +
                $"f1 <= f2){f1 <= f2}\n" +
                $"f1 >= f2){f1 >= f2}\n");

            Console.WriteLine($"Сложение рациональных чисел:\t{f1 + f2}");

            Console.WriteLine($"Вычитание рациональных чисел:\t{f1 - f2}");

            Console.WriteLine($"Операция инкремента рационального числа f1:\t{f1++}");

            Console.WriteLine($"Операция декремента рационального числа f2:\t{f2--}");

            Console.WriteLine($"Умножение рациональных чисел:\t{f1 * f2}");

            Console.WriteLine($"Деление рациональных чисел:\t{f1 / f2}");

            Console.WriteLine($"Остаток от деления рациональных чисел (некорректная операция для рациональных чисел):\t{f1 % f2}");

            float temp = f1;

            Console.WriteLine($"Операция неявного приведения рационального числа f1 к типу float:\t{temp}");

            Console.WriteLine($"Операция явного приведения рационального числа f2 к типу int:\t{(int)(f2)}");

            Console.WriteLine("Для продолжения нажмите любую клавишу...");

            Console.ReadKey();

        }

        /// <summary>
        /// Тестовый метод для комплексных чисел
        /// </summary>
        public static void TestComplex()
        {
            Console.WriteLine("Тестовый пример класса комплексных чисел");

            Console.WriteLine();

            var c1 = new Complex(5.2, 7.4);

            var c2 = new Complex(12.6, 8.07);

            Console.WriteLine("Создали 2 комплексных числа");

            Console.WriteLine(c1);

            Console.WriteLine(c2);

            Console.WriteLine("Для продолжения нажмите любую клавишу...");

            Console.ReadKey();
           
            Console.WriteLine($"Сложение комплексных чисел:\t{(c1 + c2)}");

            Console.WriteLine($"Умножение комплексных чисел:\t{(c1 * c2)}");

            Console.WriteLine($"Вычитание комплексных чисел:\t{(c1 - c2)}");

            Console.WriteLine("Для продолжения нажмите любую клавишу...");

            Console.ReadKey();
        }
    }
}
