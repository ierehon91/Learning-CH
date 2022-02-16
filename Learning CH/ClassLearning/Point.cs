using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLearning
{
    class Point
    {
        private int x;
        private int y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // перегруженный конструктор принимает в качестве аргумента объект класса Point
        public Point(Point point) 
        {
            x = point.x;
            y = point.y;
        }

        public void Print()
        {
            Console.WriteLine($"X: {x}\nY: {y}");
        }
    }
}
