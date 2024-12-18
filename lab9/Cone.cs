using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    public class Cone : ITrigonometricFigure
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public Cone(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double GetSurfaceArea()
        {
            double slantHeight = Math.Sqrt(Radius * Radius + Height * Height);
            return Math.PI * Radius * (Radius + slantHeight);
        }
    }
}
