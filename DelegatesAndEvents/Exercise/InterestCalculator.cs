using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public delegate double CalculateInterest(double sum,double interest, int years);

    class InterestCalculator
    {
        public InterestCalculator(double sum, double interest, int years, CalculateInterest calculationMethod)
        {
            this.Sum = sum;
            this.Interest = interest;
            this.Years = years;
            this.CalculateInterest = calculationMethod(sum,interest,years);
        }

        public double Sum { get; set; }
        public double Interest { get; set; }
        public int Years { get; set; }
        public double CalculateInterest { get; set; }
    }
}
