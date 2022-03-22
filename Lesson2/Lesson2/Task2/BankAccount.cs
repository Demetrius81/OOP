using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Task2
{
    //  Изменить класс счет в банке из упражнения таким образом, чтобы
    //  номер счета генерировался сам и был уникальным.
    //  Для этого надо создать в классе статическую переменную
    //  и метод, который увеличивает значение этого переменной.

    enum BankAccountType
    {
        current = 1,
        credit = 2,
        deposit = 3,
        budgetary = 4
    }

    internal class BankAccount
    {
        /// <summary>
        /// Номер счета
        /// </summary>
        private static int _accountId;

        /// <summary>
        /// Баланс
        /// </summary>
        private decimal _currentBalance;

        /// <summary>
        /// Тип банковского счета
        /// </summary>
        private BankAccountType _bankAccountType;

        /// <summary>
        /// Метод для заполнения полей класса
        /// </summary>
        /// <param name="accountId"></param>
        /// <param name="bankAccountType"></param>
        /// <param name="currentBalance"></param>
        public void InitiateAccount(BankAccountType bankAccountType, decimal currentBalance)
        {
            _accountId++;

            _bankAccountType = bankAccountType;

            _currentBalance = currentBalance;
        }

        public int Get_AccountId()
        {
            return _accountId;
        }

        public decimal Get_CurrentBalance()
        {
            return _currentBalance;
        }

        public BankAccountType Get_BankAccountType()
        {
            return _bankAccountType;
        }

        public override string ToString()
        {
            return $"Счет номер: {_accountId}, тип счета: {_bankAccountType}, текущий баланс: {_currentBalance}.";
        }
    }
}

