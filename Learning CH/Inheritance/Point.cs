using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Point2D
    {
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public void Print2D()
        {
            Console.WriteLine($"X: {X}");
            Console.WriteLine($"Y: {Y}");
        }
    }

    class Point3D : Point2D
    {
        public Point3D(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public int Z { get; set; }

        public void Print3D()
        {
            base.Print2D();
            Console.WriteLine($"Z: {Z}");
        }
    }
}