using System;

namespace Lesson2.Task3
{
    internal class Demo
    {
        public static void Task3Demo()
        {
            Console.Clear();

            Console.WriteLine("Демонстрация работы третьей задачи.");

            BankAccount bankAccount1 = new BankAccount();

            BankAccount bankAccount2 = new BankAccount(25000);

            BankAccount bankAccount3 = new BankAccount(BankAccountType.credit);

            BankAccount bankAccount4 = new BankAccount(BankAccountType.budgetary, 78500);

            Console.WriteLine("Инициализация с конструктором без параметров");

            Console.WriteLine($"Счет номер: {bankAccount1.Get_AccountId()}");

            Console.WriteLine($"Тип счета: {bankAccount1.Get_BankAccountType()}");

            Console.WriteLine($"Текущий баланс: {bankAccount1.Get_CurrentBalance()}");

            Console.WriteLine("Инициализация с конструктором с указанием текущего балланса счета");

            Console.WriteLine($"Счет номер: {bankAccount2.Get_AccountId()}");

            Console.WriteLine($"Тип счета: {bankAccount2.Get_BankAccountType()}");

            Console.WriteLine($"Текущий баланс: {bankAccount2.Get_CurrentBalance()}");

            Console.WriteLine("Инициализация с конструктором с указанием типа счета");

            Console.WriteLine($"Счет номер: {bankAccount3.Get_AccountId()}");

            Console.WriteLine($"Тип счета: {bankAccount3.Get_BankAccountType()}");

            Console.WriteLine($"Текущий баланс: {bankAccount3.Get_CurrentBalance()}");

            Console.WriteLine("Инициализация с конструктором с указанием текущего балланса и типа счета");

            Console.WriteLine($"Счет номер: {bankAccount4.Get_AccountId()}");

            Console.WriteLine($"Тип счета: {bankAccount4.Get_BankAccountType()}");

            Console.WriteLine($"Текущий баланс: {bankAccount4.Get_CurrentBalance()}");

            Console.WriteLine($"To continue press any key...");

            Console.ReadKey();
        }
    }
}
