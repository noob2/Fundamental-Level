using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice
{
    class Program
    {
        static void Main(string[] args)
        {
            Country bg = new Country("Bulgaria", 7100000, 111000, "Sofia", "Plovdiv", "Varna");
            Country usa = new Country("USA", 300000000, 1200000, "New York", "Los Angeles", "San Francisco");
            Country bg2 = new Country("Bulgaria", 8000000, 10);
            Country bg3 = new Country("Bulgaria", 8000000, 111000);
            Country hr = new Country("Croatia", 8000000, 111000);

            var bgCopy = bg.Clone() as Country;
            bg.Cities.Add("Kaspichan");
            Console.WriteLine(string.Join(", ", bg.Cities));
            Console.WriteLine(string.Join(", ", bgCopy.Cities));

        }
    }
}
