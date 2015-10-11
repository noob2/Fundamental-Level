namespace BankOfKurtovo.interfaces
{
    interface IDepositAccount
    {
        void Deposit(double amount);
        void Withdraw(double amount);
        double CalculateInterest(double months);
    }
}
