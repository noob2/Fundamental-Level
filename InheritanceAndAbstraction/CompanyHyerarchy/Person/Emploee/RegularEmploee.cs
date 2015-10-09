using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHyerarchy.Person.Emploee
{
    class RegularEmploee : Emploee
    {
        public RegularEmploee(string id, string firstName, string lastName, int salary, Department department) 
            : base(id, firstName, lastName, salary, department)
        {

        }
    }
}
