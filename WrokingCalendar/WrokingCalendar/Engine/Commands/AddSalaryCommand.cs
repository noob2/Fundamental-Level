using System;
using System.Linq;
using WrokingCalendar.Attributes;

namespace WrokingCalendar.Engine.Commands
{
    [Command]
    public class AddSalaryCommand : Command
    {
        public AddSalaryCommand(WorkCalerndarEngine engine) : base(engine)
        {
        }

        public override void Execute(string[] command)
        {
            if (command.Length < 2)
            {
                throw new ArgumentNullException("FirstName", "First name cannot be empty");
            }
            
            if (command.Length < 3)
            {
                throw new ArgumentNullException("Salary", "You must add salary");
            }

            string firstName = command[1];
            string salaryString = command[2];

            int salary;
            bool canParse = int.TryParse(salaryString,out salary);

            if (canParse)
            {
                var firstOrDefault = WorkCalerndarEngine.Workers.FirstOrDefault(w => w.FirstName == firstName);
                if (firstOrDefault == null)
                {
                    WorkCalerndarEngine.Renderer.WriteLine("Worker not found");
                }
                else
                {
                    firstOrDefault.Salary = salary;
                    WorkCalerndarEngine.Renderer.WriteLine("salary added");
                }
            }
            else
            {
                throw new ArgumentNullException("Salary", "You must add salary");
            }
        }
    }
}
