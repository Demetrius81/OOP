using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Task5
{
    internal class Demo
    {
        public static void Task5Demo()
        {
            Console.Clear();

            Console.WriteLine($"Демонстрация работы пятой задачи.\nДобавлены методы снятия и пополнения счета. Переопределен ToString.\nПри выходе из программы текущий ID сохраняется в файл accid.bin.");

            Console.WriteLine();

            BankAccount bankAccount1 = new BankAccount(BankAccountType.current, 40000);

            Console.WriteLine(bankAccount1.ToString());

            Console.WriteLine("Снимаем 30000");

            bool isDone = bankAccount1.WithdrawCurrentBalance(30000);

            Console.WriteLine(ResultWithdrawCurrentBalance(isDone));

            Console.WriteLine(bankAccount1.ToString());

            Console.WriteLine("Снимаем еще 20000");

            isDone = bankAccount1.WithdrawCurrentBalance(30000);

            Console.WriteLine(ResultWithdrawCurrentBalance(isDone));

            Console.WriteLine(bankAccount1.ToString());

            Console.WriteLine();

            Console.WriteLine("Создаем новый счет");

            BankAccount bankAccount2 = new BankAccount(BankAccountType.credit, 10000);

            Console.WriteLine(bankAccount2.ToString());

            Console.WriteLine("Кладем на счет 50000");

            bankAccount2.AddCurrentBalance(50000);

            Console.WriteLine(bankAccount2.ToString());

            Console.ReadKey();
        }

        private static string ResultWithdrawCurrentBalance(bool isDone)
        {
            if (isDone)
            {
                return "Операция прошла успешно";
            }
            else
            {
                return "Операция не удалась, недостаточно средств.";
            }
        }
    }
}
