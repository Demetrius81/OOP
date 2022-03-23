
namespace Lesson2.Task4
{
    //  В классе все методы для заполнения и получения значений полей заменить на свойства.
    //  Написать тестовый пример.

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
        #region Fields and Properties

        /// <summary>
        /// Статическое поле для хранения последнего созданного номера счета
        /// </summary>
        private static int _id;

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
            _id++;

            _accountId = _id;
        }
    }
}
