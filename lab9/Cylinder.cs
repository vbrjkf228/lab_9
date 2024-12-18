using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    public class Cylinder : ITrigonometricFigure
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double GetSurfaceArea()
        {
            return 2 * Math.PI * Radius * (Radius + Height);
        }
    }
}
