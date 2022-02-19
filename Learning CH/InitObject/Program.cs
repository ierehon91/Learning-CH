using System;

namespace InitObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person
            {
                FirstName = "Andrey",
                SecondName = "Plekhanov",
                Address = new Address 
                { 
                    City = "Vorovezh",
                    Street = "Voroshilova",
                    Home = "15"
                }
            };

            person.Print();
        }
    }
}
