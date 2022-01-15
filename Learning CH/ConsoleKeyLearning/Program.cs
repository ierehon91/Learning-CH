using System;

namespace ConsoleKeyLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            do
            {
                System.Console.Write("Нажмите кнопку на клавиатуре для получения данных: ");
                key = GetConsumerKey();
                Console.WriteLine($"Key: {key.Key}\nChar: {key.KeyChar}\nModifiers: {key.Modifiers}\n\n");
            }
            while (key.Key != System.ConsoleKey.Escape);

            System.Console.WriteLine("End");
        }

        static ConsoleKeyInfo GetConsumerKey()
        {
            ConsoleKeyInfo consumerKey = Console.ReadKey();
            System.Console.WriteLine();
            return consumerKey;
        }
    }
}
