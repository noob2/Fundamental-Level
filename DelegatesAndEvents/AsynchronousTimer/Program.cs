using System;

namespace AsynchronousTimer
{
    class Program
    {
        static void Main()
        {
            Action cw = new Action(AddNewLine);
            Action cw2 = new Action(AddNewLine2);

            AsyncTimer timer = new AsyncTimer(cw, 10, 100);
            timer.ExecuteAction();

            AsyncTimer timer2 = new AsyncTimer(cw2, 10, 100);
            timer2.ExecuteAction();
        }

        public static void AddNewLine()
        {
            Console.WriteLine("abb");
        }

        public static void AddNewLine2()
        {
            Console.WriteLine("aaa");
        }
    }
}
