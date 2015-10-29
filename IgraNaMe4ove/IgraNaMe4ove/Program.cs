using IgraNaMe4ove.GameObject.characters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IgraNaMe4ove
{
    class Program
    {
        static void Main()
        {

            int[] numbers = new int[] { 3, 5, 7, 9, 2, 3, 7, 9 };

            int num = numbers.FirstOrDefault(x => x > 7);

            foreach (var item in numbers)
            {
                Console.WriteLine(item+1);
            }





        }
    }
}
