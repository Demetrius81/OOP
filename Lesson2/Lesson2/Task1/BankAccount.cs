
namespace Lesson2.Task1
{
    //  Создать класс счет в банке с закрытыми полями:
    //      номер счета,
    //      баланс,
    //      тип банковского счета (использовать перечислимый тип).
    //  Предусмотреть методы для доступа к данным – заполнения и чтения.
    //  Создать объект класса,
    //  заполнить его поля
    //  и вывести информацию об объекте класса на печать.

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
        /// <param name="accountId"></param>
        /// <param name="bankAccountType"></param>
        /// <param name="currentBalance"></param>
        public void InitiateAccount(int accountId, BankAccountType bankAccountType, decimal currentBalance)
        {
            _accountId = accountId;

            _bankAccountType = bankAccountType;

            _currentBalance = currentBalance;
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
