using System;
using System.Collections.Generic;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> collection = new List<int> { 1, 3, 5, 6, 7, 8, 3, 8, 0, 6, 4 };
            collection.ForEach(Console.Write);
        }
    }
}