namespace BankOfKurtovo.interfaces
{
    interface IIoanAccount
    {
        void Deposit(double amount);
        double CalculateInterest(double months);
    }
}
