using System;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            for (int i = 0; i < 20; i++)
            {
                list.Add(i);
            }
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());

            list.Version();
        }
    }
}
