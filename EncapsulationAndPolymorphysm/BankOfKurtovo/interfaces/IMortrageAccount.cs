namespace BankOfKurtovo.interfaces
{
    interface IMortrageAccount
    {
        void Deposit(double amount);
        double CalculateInterest(double months);
    }
}
