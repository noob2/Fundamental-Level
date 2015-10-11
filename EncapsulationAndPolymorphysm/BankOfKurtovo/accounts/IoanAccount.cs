using BankOfKurtovo.interfaces;

namespace BankOfKurtovo.accounts
{
    public class IoanAccount : account , IIoanAccount
    {
        public IoanAccount(CostumerType costumerTytpe, double balance, double interestRate) : base(costumerTytpe, balance,interestRate)
        {
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public double CalculateInterest(double months)
        {
            if (this.CostumerType == CostumerType.individual)
            {
                if (months < 3)
                {
                    return this.Balance;
                }
                else
                {
                    double interest = this.Balance * (1 + this.InterestRate * (months - 3));
                    return interest;
                }
            }
            else
            {
                if (months < 2)
                {
                    return this.Balance;
                }
                else
                {
                    double interest = this.Balance * (1 + this.InterestRate * (months - 2));
                    return interest;
                }
            }
        }
    }
}
