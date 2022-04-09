using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3.Task1
{
    internal static class Demo
    {
        public static void TaskDemo()
        {
            Console.Clear();

            Console.WriteLine($"Демонстрация работы первой задачи.\n" +
                              $"Добавлены методы перевода денег со счета на счет\n" +
                              $"и проверки возможности перевода денег со счета на счет");

            Console.WriteLine();

            Console.WriteLine("Создаем счет на 50000");

            BankAccount bankAccount1 = new BankAccount(BankAccountType.current, 50000);

            Console.WriteLine(bankAccount1.ToString());

            Console.WriteLine("Создаем счет на 30000");

            BankAccount bankAccount2 = new BankAccount(BankAccountType.deposit, 30000);

            Console.WriteLine(bankAccount2.ToString());

            Console.WriteLine($"Переводим 12500 со счета {bankAccount1.AccountId} на счет {bankAccount2.AccountId}");

            bool isItDone = bankAccount2.Transfer(bankAccount1, 12500);

            Console.WriteLine(ResultOperation(isItDone, "Операция не выполнена."));

            Console.WriteLine(bankAccount1.ToString());

            Console.WriteLine(bankAccount2.ToString());

            Console.WriteLine($"Переводим 50000 со счета {bankAccount2.AccountId} на счет {bankAccount1.AccountId}");

            isItDone = bankAccount1.Transfer(bankAccount2, 50000);

            Console.WriteLine(ResultOperation(isItDone, "Операция не выполнена."));

            Console.WriteLine(bankAccount1.ToString());

            Console.WriteLine(bankAccount2.ToString());

            Console.WriteLine($"To continue press any key...");

            Console.ReadKey();
        }

        private static string ResultOperation(bool isDone, string message)
        {
            if (isDone)
            {
                return "Операция прошла успешно";
            }
            else
            {
                return message;
            }
        }
    }
}
