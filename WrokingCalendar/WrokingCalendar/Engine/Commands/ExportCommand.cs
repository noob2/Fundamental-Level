using System;
using System.Collections.Generic;
using System.Linq;
using WrokingCalendar.Attributes;
using System.IO;

namespace WrokingCalendar.Engine.Commands
{
    [Command]
    public class ExportCommand : Command
    {
        public ExportCommand(WorkCalerndarEngine engine) : base(engine)
        {
        }

        public override void Execute(string[] command)
        {
            if (WorkCalerndarEngine.Workers == null || WorkCalerndarEngine.Workers.Count == 0)
            {
                WorkCalerndarEngine.Renderer.WriteLine("No workers found");
            }
            else
            {
                List<string> data = new List<string>();

                foreach (var worker in WorkCalerndarEngine.Workers)
                {
                    data.Add($"worker : {worker.FirstName} {worker.LastName}");

                    if (worker.WorkingDays.Count != 0)
                    {
                        data.Add("working days:");

                        data.AddRange(worker.WorkingDays.Select(day => day.ToLongDateString()));
                    }
                    else
                    {
                        data.Add("no working days!");
                    }
                    data.Add("--------------");
                }

                using (StreamWriter outputFile = new StreamWriter(@".\data.txt"))
                {
                    foreach (string line in data)
                        outputFile.WriteLine(line);
                }
                WorkCalerndarEngine.Renderer.WriteLine("data exported from file!");
            }
        }
    }
}
