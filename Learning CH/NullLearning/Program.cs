using System;

namespace NullLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringExample(10);
        }

        /// <summary>
        /// Случайно приваиваем значение переменной message: либо null, либо строку.
        /// Если null, то при помощи оператора ?? выведется значение, которые мы укажем.
        /// </summary>
        static void StringExample(int countPrint)
        {
            string message = null;
            Random random = new Random();
            for (int i = 0; i < countPrint; i++)
            {
                message = (random.Next(0, 2) == 0) ? null : "Not Null";
                Console.WriteLine(message ?? "Значение message = null");
            }
        }
    }
}
