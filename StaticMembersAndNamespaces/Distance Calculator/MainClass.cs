using System;
using _Point3D;

namespace Distance_Calculator
{
    class MainClass
    {
        static void Main()
        {
            Point3D newPoint1 = new Point3D(-2, 34, 4);
            Point3D newPoint2 = new Point3D(43, 3, 4);
            Console.WriteLine(newPoint1);
            Console.WriteLine(newPoint2);
            Console.WriteLine("Distance between those two :");
            Console.WriteLine(DistanceCalculator.DistanceBetweenTwoPoints(newPoint1,newPoint2));
        }
    }
}
