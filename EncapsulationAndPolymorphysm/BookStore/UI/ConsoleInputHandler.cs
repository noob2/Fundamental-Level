using BookStore.Interfaces;
using System;

namespace BookStore.UI
{
    public class ConsoleInputHandler : IInputHandler
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
