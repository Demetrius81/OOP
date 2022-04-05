using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson6.Task1
{
    internal static class Demo
    {
        public static void TaskDemo()
        {
            Console.Clear();

            Console.WriteLine($"Демонстрация работы первой задачи.\n" +
                              $"Переопределить операторы == и !=.\n" +
                              $"Переопределить методы Equals() GetHashCode() ToString().");

            Console.WriteLine();

            Console.WriteLine("Создаем счет на 50000");

            BankAccount bankAccount1 = new BankAccount(BankAccountType.current, 50000);

            Console.WriteLine(bankAccount1.ToString());

            Console.WriteLine("Создаем счет на 30000");

            BankAccount bankAccount2 = new BankAccount(BankAccountType.deposit, 30000);

            Console.WriteLine(bankAccount2.ToString());

            Console.WriteLine("Работа оператора ==");

            Console.WriteLine(bankAccount2==bankAccount1);

            Console.WriteLine("Работа оператора !=");

            Console.WriteLine(bankAccount2 != bankAccount1);

            Console.WriteLine("Работа метода Equals");

            Console.WriteLine(bankAccount2.Equals(bankAccount1));

            Console.WriteLine("Работа метода GetHashCode");

            Console.WriteLine(bankAccount2.GetHashCode());

            Console.WriteLine("Работа метода ToString");

            Console.WriteLine(bankAccount2.ToString());

            Console.WriteLine($"To continue press any key...");

            Console.ReadKey();
        }
    }
}
