namespace WrokingCalendar.Engine.Commands
{
    public abstract class Command
    {
        protected Command(WorkCalerndarEngine engine)
        {
            this.WorkCalerndarEngine = engine;
        }

        public WorkCalerndarEngine WorkCalerndarEngine { get; set; }

        public abstract void Execute(string[] command);
    }
}

