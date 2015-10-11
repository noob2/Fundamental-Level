using BankOfKurtovo.accounts;

namespace BankOfKurtovo.interfaces
{
    interface IAccount
    {
        CostumerType CostumerType { get; set; }
        double Balance { get; set;  }
        double InterestRate { get; set; }
    }
}
