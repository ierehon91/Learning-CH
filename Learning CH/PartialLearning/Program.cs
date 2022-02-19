using System;

namespace PartialLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Иван", "Иванов");
            person.PrintFullName();
        }
    }
}
