using _Point3D;
using System;

namespace Distance_Calculator
{
    public static class DistanceCalculator
    {
        public static double DistanceBetweenTwoPoints(Point3D point1, Point3D point2)
        {
            return Math.Sqrt(
                (point2.X - point1.X) * 
                (point2.X - point1.X) + 
                (point2.Y - point1.Y) * 
                (point2.Y - point1.Y) + 
                (point2.Z - point1.Z) * 
                (point2.Z - point1.Z)
                );
        }
    }
}
