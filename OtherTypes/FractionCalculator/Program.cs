using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fr1 = new Fraction(2 , 3);
            Fraction fr2 = new Fraction(1, 3);
            Fraction result = fr1 + fr2;
            Console.WriteLine(result);
            Console.WriteLine(fr2-fr1);
        }
    }
}
