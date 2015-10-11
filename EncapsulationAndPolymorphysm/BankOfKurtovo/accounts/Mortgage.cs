using BankOfKurtovo.interfaces;

namespace BankOfKurtovo.accounts
{
    class Mortgage : account , IMortrageAccount
    {
        public Mortgage(CostumerType costumerTytpe, double balance, double interestRate) : base(costumerTytpe, balance,interestRate)
        {
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public double CalculateInterest(double months)
        {
            if (this.CostumerType == CostumerType.company)
            {
                if (months <= 12)
                {
                    double interest = this.Balance * (1 + this.InterestRate * months)/2;
                    return interest;
                }
                else
                {
                    double interest = this.Balance * (1 + this.InterestRate * 12)/2 + this.Balance * (1 + this.InterestRate * (months - 12));
                    return interest;
                }
            }
            else
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    double interest = this.Balance * (1 + this.InterestRate * (months - 6));
                    return interest;
                }
            }
        }
    }
}
