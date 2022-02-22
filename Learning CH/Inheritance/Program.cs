using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lecturer professor1 = new Lecturer
            {
                FirstName = "Petr",
                LastName = "Kapica"
            };

            professor1.ObjectOfStudy = "Super Low Temperatures";
            professor1.PrintFullName();

            PrintUpperFullName(professor1);

            Student student1 = new Student
            {
                FirstName = "Igor",
                LastName = "Kurchatov"
            };

            Person[] persons = new Person[]
            {
                professor1,
                student1
            };
            PrintAllPersons(persons);

            Console.WriteLine("*********");

            Point3D point = new Point3D(10, 2, 8);
            point.Print3D();
        }

        static void PrintUpperFullName(Person person)
        {
            Console.WriteLine($"{ person.FirstName} { person.LastName}".ToUpper());
        }

        static void PrintAllPersons(Person[] persons)
        {
            foreach (Person person in persons)
            {
                Console.WriteLine($"{ person.FirstName} { person.LastName}");
            }
        }
    }
}
