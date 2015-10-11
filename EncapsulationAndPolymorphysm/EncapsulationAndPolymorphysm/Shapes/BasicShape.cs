using Shapes.Interfaces;
using System;

namespace Shapes.Shapes
{
    abstract class BasicShape : IShape
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("width", "width cannot be negative");
                }
                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("height", "height cannot be negative");
                }
                this.height = value;
            }
        }
        
        public BasicShape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();
    }
}
