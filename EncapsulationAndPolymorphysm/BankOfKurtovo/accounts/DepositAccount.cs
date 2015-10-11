using BankOfKurtovo.interfaces;

namespace BankOfKurtovo.accounts
{
    public class DepositAccount : account , IDepositAccount
    {
        public DepositAccount(CostumerType costumerTytpe, double balance, double interestRate) : base(costumerTytpe, balance,interestRate)
        {
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
        }

        public double CalculateInterest(double months)
        {
            if (this.Balance < 1000 && this.Balance >= 0)
            {
                return 0;
            }
            else
            {
                double interest = this.Balance * (1 + this.InterestRate * months);
                return interest;
            }
        }
    }
}
