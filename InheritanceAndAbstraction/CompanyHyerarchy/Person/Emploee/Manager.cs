using CompanyHyerarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHyerarchy.Person.Emploee
{
    class Manager : Emploee, IManager
    {
        public Manager(string id, string firstName, string lastName, int salary, Department department, ISet<Emploee> emploees = null) 
            : base(id, firstName, lastName , salary , department)
        {
            this.Emploees = emploees ?? new HashSet<Emploee>();
        }

        public ISet<Emploee> Emploees {get; set;}

        public void AddEmploees(ISet<Emploee> emploee)
        {
            foreach (var emp in emploee)
            {
                Emploees.Add(emp);
            }
        }
    }
}
