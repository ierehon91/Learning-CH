using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLearning
{
    class Student
    {
        public Guid id;
        public string name;
        public int age;
        public string group;

        public void Print()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("ФИО: " + name);
            Console.WriteLine("Возраст: " + age);
            Console.WriteLine("Группа: " + group);
        }
    }

    
}
