using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Task4
{
    internal class Demo
    {
        public static void Task4Demo()
        {
            Console.Clear();

            Console.WriteLine($"Демонстрация работы четвертой задачи.\nДоступ к полям осуществляется через свойства");

            BankAccount bankAccount = new BankAccount(BankAccountType.credit, 12000);

            Console.WriteLine($"Счет номер: {bankAccount.AccountId}");

            Console.WriteLine($"Тип счета: {bankAccount.BankAccountType}");

            Console.WriteLine($"Текущий баланс: {bankAccount.CurrentBalance}");

            Console.ReadKey();
        }
    }
}
