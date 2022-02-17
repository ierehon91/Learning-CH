using System;

namespace ClassLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            firstStudent.Print();

            // Создадим экземляр класса Car
            Car myCar = new Car();
            myCar.GoUp();
            myCar.PrintSpeed();
            myCar.Stop();
            myCar.PrintSpeed();

            Car myCar2 = new Car();
            myCar2.GoBack();
            myCar2.PrintSpeed();

            Point point = new Point();
            point.Print();

            Point point2 = new Point(x: 10, y: 16);
            point2.Print();

            Point point3 = new Point(point2); // скопировали параметры из объекта point2 в point3
            point3.Print();

            Point point4 = new Point(x: 1, y:2, z: 3);
            point4.Print();
        }

        static Student GetStudent()
        {
            Student student = new Student();
            student.id = Guid.NewGuid();
            student.name = "Плеханов Андрей Николаевич";
            student.age = 17;
            student.group = "НТ-081";

            return student;
        }
    }
}
