using System;
using System.Collections.Generic;
using System.Text;

namespace StaticLearning
{
    class Point
    {
        private static int x;
        private static int y;
        private int z;

        public void SetX(int x) { Point.x = x; }
        public void GetX() { Console.WriteLine(Point.x); }
        public void SetY(int y) { Point.y = y; }
        public void GetY() { Console.WriteLine(Point.y); }

        public static int Sum(int a, int b) // статический метод
        {
            // z = 20; ошибка, так как статический метод может работать только со статическими полями
            return a + b;
        }

        public int Foo(int a, int b)
        {
            return Sum(a, b); // статический метод Sum внутри нестатического работает
        }

        private static int s;
        
        public static int S  // статические свойства для статического поля
        {
            get { return s; }
            set { s = value; }
        }

    }
}
