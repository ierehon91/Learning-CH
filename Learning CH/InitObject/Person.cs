using System;
using System.Collections.Generic;
using System.Text;

namespace InitObject
{
    class Person
    {
        private string firstName;
        private string secondName;
        private Address address;

        public string FirstName { set { firstName = value; } }
        public string SecondName { set { secondName = value; } }
        public Address Address { set { address = value; } }

        public void Print()
        {
            Console.WriteLine($"Name: {firstName} {secondName}\nAddress: {address.Print()}");
        }
    }
}
