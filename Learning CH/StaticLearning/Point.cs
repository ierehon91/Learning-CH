using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLearning
{
    class Point
    {
        private static int x;
        private static int y;

        public void SetX(int x) { Point.x = x; }
        public void GetX() { Console.WriteLine(Point.x); }
        public void SetY(int y) { Point.y = y; }
        public void GetY() { Console.WriteLine(Point.y); }

    }
}
