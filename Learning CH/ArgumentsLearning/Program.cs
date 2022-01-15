using System;
using static System.Console;

namespace ArgumentsLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 2) ChangeConsoleColor(args[0], args[1]);
            WriteLine($"Count arguments: {args.Length}");
            foreach (string arg in args)
            {
                WriteLine(arg);
            }
        }

        static void ChangeConsoleColor(string foregroundColor, string backgroundColor)
        {
            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: foregroundColor,
                ignoreCase: true
            );

            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: backgroundColor,
                ignoreCase: true
            );
            System.Console.WriteLine();
        }
    }
}
