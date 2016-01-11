using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WrokingCalendar.Interfaces;

namespace WrokingCalendar.UserInterface
{
    public class Renderer : IRenderer
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
