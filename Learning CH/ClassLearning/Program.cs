using System;

namespace ClassLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            Print(firstStudent);
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

        static void Print(Student student)
        {
            Console.WriteLine("id: " + student.id);
            Console.WriteLine("ФИО: " + student.name);
            Console.WriteLine("Возраст: " + student.age);
            Console.WriteLine("Группа: " + student.group);
        }
    }
}
