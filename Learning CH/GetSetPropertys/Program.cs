using System;

namespace GetSetPropertys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.X = 10;
            point.Y = 200;
            point.Z = 825;

            Console.WriteLine("X: {0}\nY: {1}\nZ: {2}", point.X, point.Y, point.Z);
        }
    }
}
