namespace WrokingCalendar.Engine.Factories
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Attributes;
    using Commands;

    public class CommandFactory
    {
        public Command CreateCommand(string commandName, WorkCalerndarEngine engine)
        {
            var commandType = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(c => c.CustomAttributes.Any(a => a.AttributeType == typeof(CommandAttribute)) && c.Name == commandName);

            if (commandType == null)
            {
                throw new ArgumentNullException(nameof(commandName), "Unknown command");
            }

            var command = Activator.CreateInstance(commandType, engine) as Command;

            return command;
        }
    }
}
