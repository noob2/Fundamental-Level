using CompanyHyerarchy.Interfaces;
using System;

namespace CompanyHyerarchy.Person.Emploee
{
    abstract class Emploee : Person , IEmploee
    {
        private int salary;
        private Department department;

        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("salary", "salary must be positive number");
                }
                this.salary = value;
            }
        }

        public Department Department { get; set;}

        public Emploee(string id, string firstName, string lastName, int salary, Department department) : base(id,firstName,lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }
    }
}