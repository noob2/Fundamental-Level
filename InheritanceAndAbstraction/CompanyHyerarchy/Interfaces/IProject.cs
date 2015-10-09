using CompanyHyerarchy.SalesAndProjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHyerarchy.Interfaces
{
    interface IProject
    {
        string ProductName { get; set; }

        string Details { get; set; }

        DateTime Date { get; set; }

        ProjectState State { get; set; }

        void CloseProject();

        string ToString();
    }
}
