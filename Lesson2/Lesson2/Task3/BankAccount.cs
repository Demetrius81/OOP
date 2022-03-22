using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Task3
{
    //В классе банковский счет удалить методы заполнения полей.
    //Вместо этих методов создать конструкторы.
    //Переопределить конструктор по умолчанию,
    //создать конструктор для заполнения поля баланс,
    //конструктор для заполнения поля тип банковского счета,
    //конструктор для заполнения баланса и типа банковского счета.
    //Каждый конструктор должен вызывать метод, генерирующий номер счета.
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


        public BankAccount()
        {
            IncrementAccountId();
        }

        public BankAccount(decimal currentBalance)
        {
            IncrementAccountId();

            _currentBalance = currentBalance;
        }

        public BankAccount(BankAccountType bankAccountType)
        {
            IncrementAccountId();

            _bankAccountType = bankAccountType;
        }

        public BankAccount(BankAccountType bankAccountType, decimal currentBalance)
        {
            IncrementAccountId();

            _bankAccountType = bankAccountType;

            _currentBalance = currentBalance;
        }
        
        public void IncrementAccountId()
        {
            _accountId++;
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
