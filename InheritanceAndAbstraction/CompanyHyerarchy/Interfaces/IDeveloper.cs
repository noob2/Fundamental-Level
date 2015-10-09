using CompanyHyerarchy.SalesAndProjects;
using System.Collections.Generic;

namespace CompanyHyerarchy.Interfaces
{
    interface IDeveloper
    {
        ISet<Project> Projects { get; set; }

        void AddProjects(ISet<Project> projects);

        string ToString();
    }
}
