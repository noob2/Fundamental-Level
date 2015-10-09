using CompanyHyerarchy.Person.Emploee;
using System.Collections.Generic;

namespace CompanyHyerarchy.Interfaces
{
    interface IManager
    {
        ISet<Emploee> Emploees { get; set; }

        void AddEmploees(ISet<Emploee> emploee);

        string ToString();
    }
}
