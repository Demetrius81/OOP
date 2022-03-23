using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Task2
{
    //  Изменить класс счет в банке из упражнения таким образом, чтобы
    //  номер счета генерировался сам и был уникальным.
    //  Для этого надо создать в классе статическую переменную
    //  и метод, который увеличивает значение этого переменной.

    /// <summary>
    /// Типы счета
    /// </summary>
    enum BankAccountType
    {
        current = 1,
        credit = 2,
        deposit = 3,
        budgetary = 4
    }

    /// <summary>
    /// Класс банковский счет
    /// </summary>
    internal class BankAccount
    {
        /// <summary>
        /// Статическое поле для хранения последнего созданного номера счета
        /// </summary>
        private static int _id;

        /// <summary>
        /// Номер счета
        /// </summary>
        private int _accountId;

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
        /// <param name="bankAccountType">Тип банковского счета</param>
        /// <param name="currentBalance">Текущий баланс счета</param>
        public void InitiateAccount(BankAccountType bankAccountType, decimal currentBalance)
        {
            IncrementAccountId();

            _bankAccountType = bankAccountType;

            _currentBalance = currentBalance;
        }

        /// <summary>
        /// Метод создает уникальный номер счета увеличивая на единицу предыдущий номер
        /// </summary>
        public void IncrementAccountId()
        {
            _id++;

            _accountId = _id;
        }

        /// <summary>
        /// Метод возвращает номер счета
        /// </summary>
        /// <returns>Номер счета</returns>
        public int Get_AccountId()
        {
            return _accountId;
        }

        /// <summary>
        /// Метод возвращает текущий баланс счета
        /// </summary>
        /// <returns>текущий баланс счета</returns>
        public decimal Get_CurrentBalance()
        {
            return _currentBalance;
        }

        /// <summary>
        /// Метод возвращает тип банковского счета
        /// </summary>
        /// <returns>тип банковского счета</returns>
        public BankAccountType Get_BankAccountType()
        {
            return _bankAccountType;
        }
    }
}

