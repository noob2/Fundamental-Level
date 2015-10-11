using Shapes.Interfaces;
using System;

namespace Shapes.Shapes
{
    class Circle : IShape
    {
        private double radius;

        public double Radius
        {
            get
            {
                return this.radius;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("radius", "radius cannot be negative");
                }
                this.radius = value;
            }
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public double CalculateArea()
        {
            double area = this.Radius * this.Radius * Math.PI/4;
            return area;
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2*Math.PI*Radius;
            return perimeter;
        }
    }
}
