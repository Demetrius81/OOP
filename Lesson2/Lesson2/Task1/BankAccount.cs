using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2.Task1
{
    //  Создать класс счет в банке с закрытыми полями:
    //      номер счета,
    //      баланс,
    //      тип банковского счета (использовать перечислимый тип).
    //  Предусмотреть методы для доступа к данным – заполнения и чтения.
    //  Создать объект класса, заполнить его поля и вывести информацию об объекте класса на печать.


    enum BankAccountType
    {
        current   = 1,
        credit    = 2,
        deposit   = 3,
        budgetary = 4
    }

    internal class BankAccount
    {
        private int _accountId;

        private decimal _currentBalance;

        private BankAccountType _bankAccountType;
    }
}
