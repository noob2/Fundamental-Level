using System;

namespace values_and_reference_types
{
    class Program
    {
        static void SwapStrings(ref string s1,ref  string s2)
        // The string parameter is passed by reference.
        // Any changes on parameters will affect the original variables.
        {
            string temp = s1;
            s1 = s2;
            s2 = temp;
            Console.WriteLine("Inside the method: {0} {1}", s1, s2);
        }

        static void Main()
        {
            string str1 = "John";
            string str2 = "Smith";
            Console.WriteLine("Inside Main, before swapping: {0} {1}", str1, str2);

            SwapStrings(ref str1,ref  str2);   // Passing strings by reference
            Console.WriteLine("Inside Main, after swapping: {0} {1}", str1, str2);
        }
    }
}
