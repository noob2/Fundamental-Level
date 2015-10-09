using CompanyHyerarchy.SalesAndProjects;
using System.Collections.Generic;

namespace CompanyHyerarchy.Interfaces
{
    interface ISalesEmploee
    {
        ISet<Sale> Sales { get; set; }

        void AddSales(ISet<Sale> sales);

        string ToString();
    }
}
