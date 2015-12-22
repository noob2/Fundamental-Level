using WrokingCalendar.Engine;
using WrokingCalendar.Engine.Factories;
using WrokingCalendar.Interfaces;
using WrokingCalendar.UserInterface;

namespace WrokingCalendar
{
    internal class Program
    {
        private static void Main()
        {
            IRenderer renderer = new Renderer();
            IInputHandler inputHandler = new InputHandler();
            CommandFactory commandFactory = new CommandFactory();
            WorkCalerndarEngine engine = new WorkCalerndarEngine(renderer, inputHandler, commandFactory);

            engine.Run();
        }
    }
}
