using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Location locationTest = new Location(12,34,Planet.Mars);

            Console.WriteLine(locationTest);
        }
    }
}
