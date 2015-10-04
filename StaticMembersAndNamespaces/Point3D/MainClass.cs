using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Point3D
{
    class MainClass
    {
        static void Main()
        {
            Point3D newPoint = new Point3D(2, 3, 4);
            Console.WriteLine(newPoint);
            Console.WriteLine(Point3D.StartingPoint);
        }
    }
}
