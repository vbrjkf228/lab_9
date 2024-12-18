using System;
using System.Collections.Generic;
using System.Text;

namespace lab9
{
    public class Cube : ITrigonometricFigure
    {
        public double Side { get; set; }

        public Cube(double side)
        {
            Side = side;
        }

        public double GetSurfaceArea()
        {
            return 6 * Side * Side;
        }
    }
}
