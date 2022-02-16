using System;

namespace ClassLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var firstStudent = GetStudent();
            firstStudent.Print();
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
