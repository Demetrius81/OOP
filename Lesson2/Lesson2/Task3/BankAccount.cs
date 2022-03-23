
namespace Lesson2.Task3
{
    //В классе банковский счет удалить методы заполнения полей.
    //Вместо этих методов создать конструкторы.
    //Переопределить конструктор по умолчанию,
    //создать конструктор для заполнения поля баланс,
    //конструктор для заполнения поля тип банковского счета,
    //конструктор для заполнения баланса и типа банковского счета.
    //Каждый конструктор должен вызывать метод, генерирующий номер счета.

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
        #region Fields

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
