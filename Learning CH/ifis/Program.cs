using System;

namespace ifis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object money = 50;

            if (money is decimal i)
            {
                System.Console.WriteLine($"You have {i}$");
            }
            else
            {
                System.Console.WriteLine("No decimal type!!!");
            }
        }
    }
}
