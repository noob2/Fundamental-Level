using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Point3D
{
    public class Point3D
    {

        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public static Point3D StartingPoint
        {
            get
            {
                return startingPoint;
            }
        }

        public Point3D(float x, float y, float z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        private static readonly Point3D startingPoint = new Point3D(0, 0, 0);

        public override string ToString()
        {
            return string.Format("Coordinates :\nx = {0}\ny = {1}\nz = {2}",X,Y,Z);
        }
    }
}
