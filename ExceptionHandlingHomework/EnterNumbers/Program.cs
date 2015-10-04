using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        static void Main()
        {
            int start = 3;
            int end = 456;

            int[] numberArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                while (numberArray[i] == 0)
                {
                    numberArray[i] = ReadNumber(start, end);
                }
                start = numberArray[i];
            }
        }

        static int ReadNumber(int start, int end)
        {
            int num = 0;
            string input = Console.ReadLine();

            try
            {
                num = int.Parse(input);
                if (num < start || num > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a number");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is not in the range [{0};{1}]", start, end);
            }
            return num;
        }
    }
}
