using System;

namespace ConstAndReadOnly
{
    class Loger
    {
        public void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now} | INFO | {message}");
        }

        public void Warning(string message)
        {
            Console.WriteLine($"{DateTime.Now} | WARNING | {message}");
        }

        public void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now} | ERROR | {message}");
        }
    }
}
