using System;

namespace EnumLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            DayTime now = DayTime.Morning;
            PrintMessage(now); // Доброе утро
            PrintMessage(DayTime.Afternoon); // Добрый день
            PrintMessage(DayTime.Evening); // Добрый вечер
            Console.WriteLine(DoOperation(10, 5, Operation.Add)); // 15
            Console.WriteLine(DoOperation(10, 5, Operation.Subtract)); // 5
            Console.WriteLine(DoOperation(10, 5, Operation.Multiplay)); // 50
            Console.WriteLine(DoOperation(10, 5, Operation.Divide)); // 2

            Console.WriteLine((byte) now); // 0
            Console.WriteLine((int) Operation.Divide); // 3

        }

        enum DayTime : byte
        {
            Morning,
            Afternoon,
            Evening,
            Night
        }

        static void PrintMessage(DayTime dayTime)
        {
            switch (dayTime)
            {
                case DayTime.Morning:
                    Console.WriteLine("Доброе утро");
                    break;
                case DayTime.Afternoon:
                    Console.WriteLine("Добрый день");
                    break;
                case DayTime.Evening:
                    Console.WriteLine("Добрый вечер");
                    break;
                case DayTime.Night:
                    Console.WriteLine("Доброй ночи");
                    break;
            }
        }

        enum Operation
        {
            Add,
            Subtract,
            Multiplay,
            Divide
        }

        static double DoOperation(double x, double y, Operation op)
        {
            double result = op switch
            {
                Operation.Add => x + y,
                Operation.Subtract => x - y,
                Operation.Multiplay => x * y,
                Operation.Divide => x / y
            };

            return result;
        }
    }
}