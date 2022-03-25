using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Lesson2.Task5
{
    //  * Добавить в класс счет в банке два метода:
    //  снять со счета и
    //  положить на счет.
    //  Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму,
    //  и в случае положительного результата изменяет баланс.

    /// <summary>
    /// Типы вкладов
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
    [Serializable]
    internal class BankAccount
    {
        #region Fields and Properties
        
        /// <summary>
        /// Номер счета
        /// </summary>        
        private static int _accountId;

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
        public BankAccount()
        {
            IncrementAccountId();
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="currentBalance">Текущий баланс</param>
        public BankAccount(decimal currentBalance)
        {
            IncrementAccountId();

            _currentBalance = currentBalance;
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="bankAccountType">Тип Банковского счета</param>
        public BankAccount(BankAccountType bankAccountType)
        {
            IncrementAccountId();

            _bankAccountType = bankAccountType;
        }

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
        /// Метод пополняет счет
        /// </summary>
        /// <param name="amountOfMoney">Сумма</param>
        public void AddCurrentBalance(decimal amountOfMoney)
        {
            CurrentBalance += amountOfMoney;
        }

        /// <summary>
        /// Метод снимает деньги со счета
        /// </summary>
        /// <param name="amountOfMoney">Сумма</param>
        /// <returns>Достаточно ли денег на счете</returns>
        public bool WithdrawCurrentBalance(decimal amountOfMoney)
        {
            if (amountOfMoney < CurrentBalance || BankAccountType == BankAccountType.credit)
            {
                CurrentBalance -= amountOfMoney;

                return true;
            }
            return false;
        }
    }
}
