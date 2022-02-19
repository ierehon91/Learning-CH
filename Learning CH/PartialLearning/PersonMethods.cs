using System;
using System.Collections.Generic;
using System.Text;

namespace PartialLearning
{
    partial class Person
    {
        public string GetFullName()
        {
            return firstName + " " + lastName;
        }

        public void PrintFullName()
        {
            Console.WriteLine(GetFullName());
        }
    }
}
