
namespace Lesson2.Task2
{
    internal class BankAccountLogic
    {
        BankAccount account = new BankAccount();

        public void SetBankAccount(BankAccountType bankAccountType, decimal currentBalance = 0)
        {
            account.InitiateAccount(bankAccountType, currentBalance);
        }

        public BankAccount GetBankAccount()
        {
            return account;
        }

    }
}
