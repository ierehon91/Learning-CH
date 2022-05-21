using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person<int> harry = new Person<int>(0, "Harry Potter");
            Person<Guid> ron = new Person<Guid>(new Guid(), "Ron Weasley");
            Person<string> hermione = new Person<string>("hermione_001", "Hermione Granger");

            Console.WriteLine(harry.ID.GetType());

            harry.PrintPerson();
            ron.PrintPerson();
            hermione.PrintPerson();

        }
    }
}
