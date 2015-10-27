using OtherTypesExcersice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherTypesExcersice
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new CostumList<int>();
            list.Add(4);
            list.Add(5);
            list.Add(0);
            list.Remove(5);
            list.Add(12);
            Console.WriteLine(list);
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            Console.WriteLine(list[-1]);
        }
    }
}
