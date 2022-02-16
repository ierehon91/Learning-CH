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
