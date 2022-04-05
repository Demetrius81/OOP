using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson3.Task1
{
    /*
     V Для класса банковский счет переопределить операторы == 
     V и != для сравнения информации в двух счетах. 
     V Переопределить метод Equals аналогично оператору ==, 
     V не забыть переопределить метод GetHashCode(). 
     V Переопределить метод ToString() для печати информации о счете. 
     V Протестировать функционирование переопределенных методов и операторов на простом примере. 
     */

    /// <summary>
    /// Тип банковского счета
    /// </summary>
    public enum BankAccountType
    {
        current = 0x0001,
        credit = 0x0010,
        deposit = 0x0100,
        budgetary = 0x1000
    }

    /// <summary>
    /// Класс банковский счет
    /// </summary>
    [Serializable]
    internal class BankAccount
    {
        #region Fields and Properties

        /// <summary>
        /// Номер счета
        /// </summary>        
        private int _accountId;

        /// <summary>
        /// Баланс
        /// </summary>
        [NonSerialized]
        private decimal _currentBalance;

        /// <summary>
        /// Тип банковского счета
        /// </summary>
        [NonSerialized]
        private BankAccountType _bankAccountType;


        internal int AccountId { get => _accountId; }

        internal decimal CurrentBalance { get => _currentBalance; private set => _currentBalance = value; }

        internal BankAccountType BankAccountType { get => _bankAccountType; private set => _bankAccountType = value; }

        #endregion

        #region Constructors

        /// <summary>
        /// Конструктор
        /// </summary>
        public BankAccount() : this(0, 0) { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="currentBalance">Текущий баланс</param>
        public BankAccount(decimal currentBalance) : this(0, currentBalance) { }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankAccountType">Тип Банковского счета</param>
        public BankAccount(BankAccountType bankAccountType) : this(bankAccountType, 0) { }
        
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankAccountType">Тип Банковского счета</param>
        /// <param name="currentBalance">Текущий баланс</param>
        public BankAccount(BankAccountType bankAccountType, decimal currentBalance)
        {
            IncrementAccountId();

            _bankAccountType = bankAccountType;

            _currentBalance = currentBalance;
        }

        #endregion

        /// <summary>
        /// Метод создает уникальный номер счета увеличивая на единицу предыдущий номер
        /// </summary>
        private void IncrementAccountId()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            FileInfo file = new FileInfo("accid.bin");

            if (file.Exists)
            {
                using (FileStream fileStream = new FileStream("accid.bin", FileMode.OpenOrCreate))
                {
                    _accountId = (int)binaryFormatter.Deserialize(fileStream);
                }
            }
            _accountId++;

            using (FileStream fileStream = new FileStream("accid.bin", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, _accountId);
            }
        }

        /// <summary>
        /// Метод ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Счет номер: {_accountId}, " +
                                             $"тип счета: {_bankAccountType}, " +
                                             $"текущий баланс: {_currentBalance:F2}.";

        /// <summary>
        /// Метод GetHashCode
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode() => _accountId;

        /// <summary>
        /// Метод Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }
            BankAccount acc = obj as BankAccount;

            if (acc as BankAccount is null)
            {
                return false;
            }
            return acc._currentBalance == this._currentBalance && acc._accountId == this._accountId;
        }

        /// <summary>
        /// Метод Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Equals(BankAccount acc)
        {
            if (acc is null)
            {
                return false;
            }
            return acc._currentBalance == this._currentBalance && acc._accountId == this._accountId;
        }

        /// <summary>
        /// Метод пополняет счет
        /// </summary>
        /// <param name="amountOfMoney">Сумма</param>
        public void AddCurrentBalance(decimal amountOfMoney) => _currentBalance += amountOfMoney;


        /// <summary>
        /// Метод снимает деньги со счета
        /// </summary>
        /// <param name="amountOfMoney">Сумма</param>
        /// <returns>Достаточно ли денег на счете</returns>
        public bool WithdrawCurrentBalance(decimal amountOfMoney)
        {
            if (amountOfMoney < _currentBalance || BankAccountType == BankAccountType.credit)
            {
                CurrentBalance -= amountOfMoney;

                return true;
            }
            return false;
        }

        /// <summary>
        /// Мктод проверяет возможность перевода
        /// </summary>
        /// <param name="accountFrom">Банковский счет, откуда снимаются деньги</param>
        /// <param name="amountOfMoney">сумма перевода</param>
        /// <returns></returns>
        private bool СheckingЕhePossibilityTransfer(BankAccount accountFrom, decimal amountOfMoney)
        {
            if ((amountOfMoney >= 0) && (accountFrom != null) &&
               ((accountFrom._currentBalance - amountOfMoney) >= 0) &&
               ((this._currentBalance + amountOfMoney) < Decimal.MaxValue))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Метод осуществляет перевод
        /// </summary>
        /// <param name="accountFrom">Банковский счет, откуда снимаются деньги</param>
        /// <param name="amountOfMoney">сумма перевода</param>
        /// <returns></returns>
        public bool Transfer(BankAccount accountFrom, decimal amountOfMoney)
        {
            bool isTransferApproved = СheckingЕhePossibilityTransfer(accountFrom, amountOfMoney);

            if (isTransferApproved)
            {
                try
                {
                }
                finally
                {
                    accountFrom._currentBalance -= amountOfMoney;

                    this._currentBalance += amountOfMoney;
                }
            }
            return isTransferApproved;
        }

        /// <summary>
        /// Определение оператора ==
        /// </summary>
        /// <param name="bankAccount1">BankAccount аккаунт 1</param>
        /// <param name="bankAccount2">BankAccount аккаунт 2</param>
        /// <returns>bool результат</returns>
        public static bool operator ==(BankAccount bankAccount1, BankAccount bankAccount2) => bankAccount1.Equals(bankAccount2);

        /// <summary>
        /// Определение оператора !=
        /// </summary>
        /// <param name="bankAccount1">BankAccount аккаунт 1</param>
        /// <param name="bankAccount2">BankAccount аккаунт 2</param>
        /// <returns>bool результат</returns>
        public static bool operator !=(BankAccount bankAccount1, BankAccount bankAccount2) => !bankAccount1.Equals(bankAccount2);
        
    }
}
