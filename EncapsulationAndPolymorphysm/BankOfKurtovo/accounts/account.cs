using BankOfKurtovo.interfaces;
using System;

namespace BankOfKurtovo.accounts
{
    public abstract class account : IAccount
    {
        public account(CostumerType costumerTytpe, double balance, double interestRate)
        {
            this.CostumerType = costumerTytpe;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        private double balance;
        private double interestRate;

        public CostumerType CostumerType { get; set; }
        public double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("BALANCE CANNOT BE NEGATIVE");
                }
                this.balance = value;
            }
        }
        public double InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("INTEREST RATE CANNOT BE NEGATIVE");
                }
                this.interestRate = value;
            }
        }
    }
}
