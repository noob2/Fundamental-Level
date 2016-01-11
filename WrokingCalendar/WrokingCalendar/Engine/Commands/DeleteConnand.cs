using System;
using System.Linq;
using WrokingCalendar.Attributes;

namespace WrokingCalendar.Engine.Commands
{
    [Command]
    public class DeleteCommand : Command
    {
        public DeleteCommand(WorkCalerndarEngine engine) : base(engine)
        {
        }

        public override void Execute(string[] command)
        {
            if (command.Length < 2)
            {
                throw new ArgumentNullException("FirstName","First name cannot be empty");
            }
            string firstName = command[1];

            Worker workerToRemove = WorkCalerndarEngine.Workers.FirstOrDefault(w => w.FirstName == firstName);

            if (workerToRemove == null)
            {
                WorkCalerndarEngine.Renderer.WriteLine("Worker not found");
            }
            else
            {
                WorkCalerndarEngine.Workers.Remove(workerToRemove);
                WorkCalerndarEngine.Renderer.WriteLine("Worker removed");
            }
        }
    }
}
