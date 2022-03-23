using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Task2
{
    internal class Demo
    {
        public static void Task2Demo()
        {
            Console.Clear();

            Console.WriteLine("Демонстрация работы второй задачи.");

            BankAccount bankAccount = new BankAccount();

            bankAccount.InitiateAccount(BankAccountType.deposit, 150000);

            BankAccount bankAccount2 = new BankAccount();

            bankAccount2.InitiateAccount(BankAccountType.current, 10000);

            Console.WriteLine($"Счет номер: {bankAccount.Get_AccountId()}");

            Console.WriteLine($"Тип счета: {bankAccount.Get_BankAccountType()}");

            Console.WriteLine($"Текущий баланс: {bankAccount.Get_CurrentBalance()}");

            Console.WriteLine($"Счет номер: {bankAccount2.Get_AccountId()}");

            Console.WriteLine($"Тип счета: {bankAccount2.Get_BankAccountType()}");

            Console.WriteLine($"Текущий баланс: {bankAccount2.Get_CurrentBalance()}");

            Console.ReadKey();
        }
    }
}
