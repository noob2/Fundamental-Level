using System;
using WrokingCalendar.Interfaces;

namespace WrokingCalendar.UserInterface
{
    public class InputHandler : IInputHandler
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
