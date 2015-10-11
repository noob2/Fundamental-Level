using BookStore.Interfaces;
using System;

namespace BookStore.UI
{
    public class ConsoleRenderer : IRenderer
    {
        public void WriteLine(string message, params object[] parameters)
        {
            Console.WriteLine(message, parameters);
        }
    }
}
