using CompanyHyerarchy.Person.Emploee;
using CompanyHyerarchy.SalesAndProjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  Create the following OOP class hierarchy :
//  Person – general class for anyone, holding id, first name and last name.
//      Employee – general class for all employees, holding the field salary and department.
//          The department can only be one of the following: Production, Accounting, Sales or Marketing.
//          Manager – holds a set of employees under his command.
//          RegularEmployee
//          SalesEmployee – holds a set of sales.A sale holds product name, date and price.
//          Developer – holds a set of projects.A project holds project name, project start date, details and a state (open or closed). 
//      A project can be closed through the method CloseProject().
//      Customer – holds the net purchase amount(total amount of money the customer has spent).
//  Extract interfaces for each class. (e.g.IPerson, IEmployee, IManager, etc.).
//  The interfaces should hold their public properties and methods(e.g.IPerson should hold id, first name and last name).
//  Each class should implement its respective interface.
//  Define proper constructors.Avoid code duplication through abstraction.Encapsulate all data and validate the input.
//  Throw exceptions where necessary.Override ToString() in all classes to print detailed information about the object.
//  Create several employees of type Manager, SalesEmployee and Developer and add them in a single collection.Finally, print them in a for-each loop.


namespace CompanyHyerarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager("0000000001", "Manager1", "Manager1 Last name",123, Department.Accounting);
            Manager manager2 = new Manager("0000000002", "Manager2", "Manager2 Last name", 3124, Department.Sales);
            Manager manager3 = new Manager("0000000003", "Manager2", "Manager2 Last name", 1423, Department.Marketing);

            SalesEmployee salesEmployee1 = new SalesEmployee("0000000004", "SalesEmployee1", "SalesEmployee1 Last name", 512, Department.Accounting);
            SalesEmployee salesEmployee2 = new SalesEmployee("0000000005", "SalesEmployee2", "SalesEmployee2 Last name", 513, Department.Marketing);
            SalesEmployee salesEmployee3 = new SalesEmployee("0000000006", "SalesEmployee3", "SalesEmployee3 Last name", 1000, Department.Production);

            Developer developer1 = new Developer("0000000007", "Developer1", "Developer1 Last name", 5523, Department.Marketing);
            Developer developer2 = new Developer("0000000008", "Developer2", "Developer2 Last name", 513, Department.Sales);
            Developer developer3 = new Developer("0000000009", "Developer3", "Developer3 Last name", 523, Department.Accounting);

            Sale sale = new Sale("graphic card", DateTime.Now, 220);
            Project project = new Project("OOP", DateTime.Now, "OOP course");   

            manager1.AddEmploees(new HashSet<Emploee> { salesEmployee1, developer3 });
            salesEmployee1.AddSales(new HashSet<Sale> { sale });
            developer1.AddProjects(new HashSet<Project> { project });

            IList<Emploee> employees = new List<Emploee>
            {
                manager1,
                manager2,
                manager3,
                salesEmployee1,
                salesEmployee2,
                salesEmployee3,
                developer1,
                developer2,
                developer3
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
