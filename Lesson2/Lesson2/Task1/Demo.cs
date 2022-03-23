using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Task1
{
    internal class Demo
    {
        public static void Task1Demo()
        {
            Console.Clear();

            Console.WriteLine("Демонстрация работы первой задачи.");

            BankAccount bankAccount = new BankAccount();

            bankAccount.InitiateAccount(4, BankAccountType.deposit, 150000);

            Console.WriteLine($"Счет номер: {bankAccount.Get_AccountId()}");

            Console.WriteLine($"Тип счета: {bankAccount.Get_BankAccountType()}");

            Console.WriteLine($"Текущий баланс: {bankAccount.Get_CurrentBalance()}");

            Console.ReadKey();
        }
    }
}
