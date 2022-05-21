using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    internal class Person<T>
    {
        public T ID { get; set; }
        public string Name { get; set; }

        public Person(T id, string name)
        {
            ID = id;
            Name = name;
        }

        public void PrintPerson()
        {
            Console.WriteLine($"ID: {ID}. Name: {Name}");
        }
    }
}
