using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLearning
{
    class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Print()
        {
            Console.WriteLine($"X: {x}\nY: {y}");
        }
    }
}
