using System;
using System.Collections.Generic;
using WrokingCalendar.Engine.Factories;
using WrokingCalendar.Interfaces;

namespace WrokingCalendar.Engine
{
    public class WorkCalerndarEngine
    {
        
        public readonly IRenderer Renderer;
        public readonly IInputHandler InputHandler;
        private readonly IList<Worker> workers = new List<Worker>(); 

        public WorkCalerndarEngine(IRenderer renderer, IInputHandler inputHandler, CommandFactory commandFactory)
        {
            this.Renderer = renderer;
            this.InputHandler = inputHandler;
            this.CommandFactory = commandFactory;
        }

        public IList<Worker> Workers
        {
            get
            {
                return this.workers;
            }
        }

        public CommandFactory CommandFactory { get; }

        public void Run()
        {
            string[] conttrolsInfo = { "ControlsInfoCommand" };
            this.CommandFactory.CreateCommand(conttrolsInfo[0], this).Execute(conttrolsInfo);

            while (true)
            {
                string[] comand = InputHandler.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (comand.Length == 0 || string.IsNullOrWhiteSpace(comand[0]))
                {
                    Renderer.WriteLine("Command cannot be null");
                    continue;
                }

                const string CommandSuffix = "Command";

                comand[0]+=CommandSuffix;

                try
                {
                    var command = this.CommandFactory.CreateCommand(comand[0], this);
                    command.Execute(comand);
                }
                catch (ArgumentNullException ex)
                {
                    Renderer.WriteLine(ex.Message);
                }
            }
        }
    }
}
