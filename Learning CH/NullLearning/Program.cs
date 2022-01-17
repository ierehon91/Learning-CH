using System;

namespace NullLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringExample(10);
            Console.WriteLine(GetLengthArray(GetArray(15)));
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

        static int[] GetArray()
        {     
            return null;
        }

        static int[] GetArray(int length)
        {
            return new int[length];
        }

        /// <summary>
        /// Метод возврата числа элементов в массиве целых чисел
        /// При передачи массива со значением null вернёт 0
        /// /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int GetLengthArray(int[] array)
        {
            array ??= new int[0];
            return array.Length;
        }

    }
}
