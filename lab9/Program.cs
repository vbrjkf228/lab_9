using System;

namespace lab9
{
    class Program
    {
        static void Main()
        {
            ITrigonometricFigure[] figures =
            {
            new Cylinder(5, 10),
            new Cube(4),
            new Cone(3, 7)
        };

            foreach (var figure in figures)
            {
                Console.WriteLine($"{figure.GetType().Name}: Площа поверхні = {figure.GetSurfaceArea():F2}");
            }
        }
    }
}
