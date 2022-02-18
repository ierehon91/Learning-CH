using System;
using MyExtencion;

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

            int sum = Point.Sum(6, 3); // вызов статического метода класса Point
            Console.WriteLine(sum);

            int sum2 = point2.Foo(6, 4);
            Console.WriteLine(sum2);

            Point.S = 250;
            Console.WriteLine(Point.S);

            Console.WriteLine("\nСчитаем количество экземпляров класса CounterObjects: ");
            Console.WriteLine(CounterObjects.Counter); // 0
            CounterObjects object_1 = new CounterObjects();
            CounterObjects object_2 = new CounterObjects();
            Console.WriteLine(CounterObjects.Counter); // 2
            CounterObjects object_3 = new CounterObjects();
            Console.WriteLine(CounterObjects.Counter); // 3

            DataBaseConnected connect1 = new DataBaseConnected();
            connect1.PrintUrlHash();
            DataBaseConnected connect2 = new DataBaseConnected();
            connect2.PrintUrlHash();

            DateTime currentDateTime = DateTime.Now;
            currentDateTime.Print();
            Console.WriteLine(currentDateTime.isDayOfWeek(DayOfWeek.Friday));

        }
    }
}
