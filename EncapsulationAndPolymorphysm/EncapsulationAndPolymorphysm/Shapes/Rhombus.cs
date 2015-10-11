namespace Shapes.Shapes
{
    class Rhombus : BasicShape
    {

        public Rhombus(double width, double height) : base(width,height)
        {

        }

        public override double CalculateArea()
        {
            return -1;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = (this.Width * 2) + (this.Height * 2);
            return perimeter;
        }
    }
}
