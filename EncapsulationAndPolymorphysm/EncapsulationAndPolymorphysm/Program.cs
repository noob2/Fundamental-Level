using Shapes.Interfaces;
using Shapes.Shapes;
using System;
using System.Collections.Generic;
//Define an interface IShape with two abstract methods: CalculateArea() and CalculatePerimeter().
//Define an abstract class BasicShape implementing IShape and holding width and height.Leave the methods CalculateArea() and CalculatePerimeter() abstract.
//Define two new BasicShape subclasses: Rhombus and Rectangle that implement the abstract methods CalculateArea() and CalculatePerimeter().
//Define a class Circle implementing IShape with a suitable constructor.
//Create an array of different shapes (Circle, Rectangle, Rhombus) and test the behavior of the CalculateSurface() and CalculatePerimeter() methods.

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> figures = new List<IShape>
            {
                new Circle(43),
                new Rectangle(12,2),
                new Rhombus(2,2)
            };

            foreach (var figure in figures)
            {
                Console.WriteLine("Figure :{0}, area :{1:F2}, perimeter :{2:F2}",figure.GetType().Name,figure.CalculateArea(),figure.CalculatePerimeter());
            }
        }
    }
}
