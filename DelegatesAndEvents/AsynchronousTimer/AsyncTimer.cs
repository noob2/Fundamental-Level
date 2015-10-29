using System;
using System.Threading;

namespace AsynchronousTimer
{
    class AsyncTimer
    {
        public AsyncTimer(Action action, int ticks, int timeBetweenTick)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.TimeBetweenTick = timeBetweenTick;
        }

        public Action Action { get; set; }
        public int Ticks { get; set; }
        public int TimeBetweenTick { get; set; }

        public void ExecuteAction()
        {
            Thread parallelThread = new Thread(this.Run);
            parallelThread.Start();
        }

        private void Run()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.TimeBetweenTick);

                this.Action();
            }
        }
    }
}