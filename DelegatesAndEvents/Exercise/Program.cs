using System;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        public static void Main()
        {
            var acc1 = new InterestCalculator(500, 5.6, 10, CompoundInterest);
            var acc2 = new InterestCalculator(2500, 7.2, 15, SimpleInterest);

            Console.WriteLine(acc1.CalculateInterest);
            Console.WriteLine(acc2.CalculateInterest);
        }

        public static double SimpleInterest(double sum, double interest, int years)
        {
            return sum * (1 + (interest / 100 * years));
        }

        public static double CompoundInterest(double sum, double interest, int years)
        {
            return sum * (double)Math.Pow((double)(1 + (interest / 100 / 12)), years * 12);
        }
    }
}