using BankOfKurtovo.accounts;

//bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts.
//Customers could be individuals or companies.
//All accounts have customer, balance and interest rate (monthly based). 
//Deposit accounts are allowed to deposit and withdraw money.Loan and mortgage accounts can only deposit money.
//All accounts can calculate their interest for a given period (in months) using the formula
//A = money * (1 + interest rate* months) 
//Loan accounts have no interest for the first 3 months if held by individuals and for the first 2 months if held by a company.
//Deposit accounts have no interest if their balance is positive and less than 1000.
//Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
//Write a program to model the bank system with classes and interfaces. 
//You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
//Write a program to demonstrate that your classes work correctly.


namespace BankOfKurtovo
{
    class Program
    {
        static void Main()
        {
            DepositAccount viktor = new DepositAccount(CostumerType.company, 1000, 0.02);
            System.Console.WriteLine(viktor.Balance);
            viktor.Deposit(100);
            System.Console.WriteLine(viktor.Balance);
            viktor.Deposit(2000);
            System.Console.WriteLine(viktor.Balance);
            IoanAccount svetlozar = new IoanAccount(CostumerType.company, 1000, 2);
            System.Console.WriteLine(viktor.CalculateInterest(12));
        }
    }
}
