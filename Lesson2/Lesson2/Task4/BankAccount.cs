using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Task4
{
    //  В классе все методы для заполнения и получения значений полей заменить на свойства.
    //  Написать тестовый пример.
   
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

        internal int AccountId { get; }

        internal decimal CurrentBalance { get; private set; }

        internal BankAccountType BankAccountType { get; private set; }

        #region Constructors
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

        #endregion

        private void IncrementAccountId()
        {
            _accountId++;
        }
        
        public override string ToString()
        {
            return $"Счет номер: {_accountId}, тип счета: {_bankAccountType}, текущий баланс: {_currentBalance}.";
        }
    }
}
