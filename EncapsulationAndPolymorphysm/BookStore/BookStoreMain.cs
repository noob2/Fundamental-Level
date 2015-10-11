namespace BookStore
{
    using Interfaces;
    using Engine;
    using UI;

    public class BookStoreMain
    {
        public static void Main()
        {
            IInputHandler inputHandler = new ConsoleInputHandler();
            IRenderer renderer = new ConsoleRenderer();

            BookStoreEngine engine = new BookStoreEngine(renderer, inputHandler);

            engine.Run();
        }
    }
}
