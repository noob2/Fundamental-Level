using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    struct Fraction
    {
        private int numerator;
        private int denominator;

        public int Numerator
        {
            get
            {
                return this.numerator;
            }
            set
            {
                this.numerator = value;
            }
        }

        public int Denuminator
        {
            get
            {
                return this.denominator;
            }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentOutOfRangeException("denominator cannot be 0");
                }
                this.denominator = value;
            }
        }

        public Fraction(int numerator, int denominator) : this()
        {
            this.Numerator = numerator;
            this.Denuminator = denominator;
        }

        public override string ToString()
        {
            float result = (float)this.numerator / this.denominator;
            return result.ToString();
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            int num1 = f1.numerator;
            int den1 = f1.denominator;
            int num2 = f2.numerator;
            int den2 = f2.denominator;

            int resultNum=num1*den2 + num2*den1;
            int resultDen = den1*den2;

            Fraction result = new Fraction(resultNum, resultDen);

            return result;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            int num1 = f1.numerator;
            int den1 = f1.denominator;
            int num2 = f2.numerator;
            int den2 = f2.denominator;

            int resultNum = num1 * den2 - num2 * den1;
            int resultDen = den1 * den2;

            Fraction result = new Fraction(resultNum, resultDen);

            return result;
        }
    }
}
