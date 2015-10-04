using System;
using System.Collections.Generic;
using _Point3D;

namespace Paths
{
    class Path3D
    {
        private readonly List<Point3D> path = new List<Point3D>();

        public List<Point3D> Path
        {
            get
            {
                return this.path;
            }
        }

        public void AddPoint(params Point3D[] list)
        {
            foreach (var Point in list)
            {
                this.path.Add(Point);
            }
        }

        public Path3D(params Point3D[] list)
        { 
             this.AddPoint(list); 
        }
    }
}
