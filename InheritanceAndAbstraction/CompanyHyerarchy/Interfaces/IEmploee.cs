using CompanyHyerarchy.Person.Emploee;

namespace CompanyHyerarchy.Interfaces
{
    interface IEmploee
    {
        int Salary { get; set; }

        Department Department { get; set; }

        string ToString();
    }
}
