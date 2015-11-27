using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        long fibonacci15 = Fibonacci(10000);

        stopWatch.Stop();

        // Get the elapsed time as a TimeSpan value.
        TimeSpan ts = stopWatch.Elapsed;

        // Format and display the TimeSpan value.
        string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
        Console.WriteLine("RunTime " + elapsedTime);

    }

    public static long Fibonacci(long n)
    {
        long a = 0;
        long b = 1;

        for (int i = 0; i < n; i++)
        {
            long temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }

    public static int FibonacciRecursion(int n)
    {
        int a = 0;
        int b = 1;

        for (int i = 0; i < n; i++)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }
        return a;
    }
}

