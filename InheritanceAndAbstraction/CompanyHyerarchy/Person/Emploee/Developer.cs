using System;
using System.Collections.Generic;
using CompanyHyerarchy.Interfaces;
using CompanyHyerarchy.SalesAndProjects;

namespace CompanyHyerarchy.Person.Emploee
{
    class Developer : Emploee , IDeveloper
    {
        public Developer(string id, string firstName, string lastName, int salary, Department department, ISet<Project> projects = null)
            : base(id, firstName, lastName, salary, department)
        {
            this.Projects = projects ?? new HashSet<Project>();
        }

        private ISet<Project> projects;

        public ISet<Project> Projects { get; set; }

        public void AddProjects(ISet<Project> projects)
        {
            foreach (var project in projects)
            {
                Projects.Add(project);
                
            }
        }
    }
}
