using System;
using System.Linq;
using WrokingCalendar.Attributes;

namespace WrokingCalendar.Engine.Commands
{
    [Command]
    public class AddWorkingDaysCommand : Command
    {
        public AddWorkingDaysCommand(WorkCalerndarEngine engine) : base(engine)
        {
        }

        public override void Execute(string[] command)
        {
            if (command.Length < 2)
            {
                throw new ArgumentNullException("FirstName", "First name cannot be empty");
            }
            string firstName = command[1];

            var firstOrDefaultWorker = WorkCalerndarEngine.Workers.FirstOrDefault(w => w.FirstName == firstName);

            if (firstOrDefaultWorker == null)
            {
                WorkCalerndarEngine.Renderer.WriteLine("Worker not found");
            }
            else
            {
                for (int i = 1; i < command.Length; i++)
                {
                    int day;
                    bool parsedDay = int.TryParse(command[i], out day);

                    if (parsedDay && day > 0 && day <= 31)
                    {
                        firstOrDefaultWorker.AddWorkingDayThisMounth(day);
                    }
                }
                //apply addition to the worker variable
                if (firstOrDefaultWorker.WorkingDays == null || firstOrDefaultWorker.WorkingDays.Count == 0)
                {
                    WorkCalerndarEngine.Renderer.WriteLine("no working days added");
                }
                else
                {
                    WorkCalerndarEngine.Renderer.WriteLine("working days for the worker :");
                    foreach (var workingDay in firstOrDefaultWorker.WorkingDays)
                    {
                        WorkCalerndarEngine.Renderer.WriteLine(workingDay.ToLongDateString());
                    }
                }
            }
        }
    }
}
