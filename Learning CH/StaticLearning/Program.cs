using System;

namespace StaticLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point();
            Point point2 = new Point();

            point1.SetX(10);  // записываем значение 10 в статическое поле x класса Point
            point1.SetY(-15); // записываем значение 10 в статическое поле y класса Point

            point2.GetX();  // 10, так как статические поля для каждого экземпляра объекта общие
            point2.GetY();  // -15
        }
    }
}
