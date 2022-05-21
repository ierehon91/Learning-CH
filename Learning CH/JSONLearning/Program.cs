using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace JSONLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string filePath = @"C:\Development\C#\Learning-CH\Learning CH\JSONLearning\person.json";
            string jsonString = File.ReadAllText(filePath);
            Person person = JsonConvert.DeserializeObject<Person>(jsonString);
            Console.WriteLine($"Name: {person.GetFullName()}\nAge: {person.Age}");
            Console.WriteLine();
            Console.WriteLine("ToDo List");
            person.PrintDayDeal();
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public List<string> TodoList { get; set; }

        public Person(string Name, string Age, List<string> TodoList)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.TodoList = TodoList;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public void PrintDayDeal()
        {
            foreach (string deal in TodoList)
            {
                Console.WriteLine($"● {deal.ToUpper()}");
            }
        }
    }
}
