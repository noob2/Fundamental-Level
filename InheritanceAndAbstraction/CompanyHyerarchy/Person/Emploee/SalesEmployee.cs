using CompanyHyerarchy.Interfaces;
using CompanyHyerarchy.SalesAndProjects;
using System.Collections.Generic;

namespace CompanyHyerarchy.Person.Emploee
{
    class SalesEmployee : Emploee, ISalesEmploee
    {
        public SalesEmployee(string id, string firstName, string lastName, int salary, Department department, ISet<Sale> sales = null)
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public ISet<Sale> Sales { get; set; }

        public void AddSales(ISet<Sale> sales)
        {
            foreach (var sale in sales)
            {
                this.Sales = sales ?? new HashSet<Sale>(); this.Sales.Add(sale);
            }
        }
    }
}
