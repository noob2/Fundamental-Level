using System;
using WrokingCalendar.Attributes;

namespace WrokingCalendar.Engine.Commands
{
    [Command]
    public class AddWorkerCommand : Command
    {
        public AddWorkerCommand(WorkCalerndarEngine engine) : base(engine)
        {
        }

        public override void Execute(string[] command)
        {
            if (command.Length < 2)
            {
                throw new ArgumentNullException("First name cannot be empty");
            }
            string firstName = command[1];

            if (command.Length < 3)
            {
                throw new ArgumentNullException("Last name cannot be empty");
            }
            string lastName = command[2];

            Worker worker = new Worker(firstName, lastName);
            WorkCalerndarEngine.Workers.Add(worker);

            WorkCalerndarEngine.Renderer.WriteLine("Worker added");
        }
    }
}
