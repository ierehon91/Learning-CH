using System;
using System.Collections.Generic;
using System.Text;

namespace PartialLearning
{
    /* 
     * Класс Person поделён на 2 файла благодоря ключивому слову partial
     * методы класса содержатся в файле PersonMethods.cs
     */

    partial class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
    }
}
