using System;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1Demo();

            for (int i = 0; i < 5; i++)
            {
                Task2Demo();
            }
        }

        static void Task2Demo()
        {
            Task2.BankAccountLogic bankAccountLogic = new Task2.BankAccountLogic();

            bankAccountLogic.SetBankAccount(Task2.BankAccountType.deposit, 150000);

            Task2.BankAccount bankAccount = bankAccountLogic.GetBankAccount();

            Console.WriteLine($"Счет номер: {bankAccount.Get_AccountId()}");

            Console.WriteLine($"Тип счета: {bankAccount.Get_BankAccountType()}");

            Console.WriteLine($"Текущий баланс: {bankAccount.Get_CurrentBalance()}");

            Console.ReadKey();
        }

        static void Task1Demo()
        {
            Task1.BankAccountLogic bankAccountLogic = new Task1.BankAccountLogic();

            bankAccountLogic.SetBankAccount(4, Task1.BankAccountType.deposit, 150000);

            Task1.BankAccount bankAccount = bankAccountLogic.GetBankAccount();

            Console.WriteLine($"Счет номер: {bankAccount.Get_AccountId()}");

            Console.WriteLine($"Тип счета: {bankAccount.Get_BankAccountType()}");

            Console.WriteLine($"Текущий баланс: {bankAccount.Get_CurrentBalance()}");

            Console.ReadKey();
        }
    }
}
