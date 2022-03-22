
namespace Lesson2.Task1
{
    internal class BankAccountLogic
    {
        BankAccount account = new BankAccount();

        public void SetBankAccount(int accountId, BankAccountType bankAccountType, decimal currentBalance = 0)
        {
            account.InitiateAccount(accountId, bankAccountType, currentBalance);
        }

        public BankAccount GetBankAccount()
        {
            return account;
        }

    }
}
