using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
