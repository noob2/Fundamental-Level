using CompanyHyerarchy.Interfaces;
using System;

namespace CompanyHyerarchy.Person.Costumer
{
    class Costumer : Person , ICostumer
    {
        private int netPurchaseAmount;

        public int NetPurchaseAmount
        {
            get
            {
                return netPurchaseAmount;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("netPurchaceAmount", "net purchise amount must be positive number");
                }
                this.netPurchaseAmount = value;
            }
        }

        public Costumer(string id, string firstName, string lastName, int netPurchaseAmount) : base(id,firstName,lastName)
        {
            this.NetPurchaseAmount = netPurchaseAmount;
        }

        public void AddPurchasePrice(int purchasePrice)
        {
            this.netPurchaseAmount += purchasePrice;
        }
    }
}
