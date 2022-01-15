using System;

namespace MethodsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintSymbols("*", 18);
            Console.WriteLine("Нахождение индекса");
            PrintSymbols("*", 18);

            int[] myArray = createRandomArray(100, 0, 100);
            Console.Write("Укажите число, индекс которого необходимо найти: ");
            int element = Int32.Parse(Console.ReadLine());
            int index = FindFirstArrayIndex(myArray, element);

            if (index != -1) Console.WriteLine($"Индекс числа {element}: {index}");
            else Console.WriteLine($"В массиве отсутсвуют элементы со значением {element}.");
        }

        static void PrintSymbols(string symbol, uint count)
        {
            for (int i = 0; i < count; i++) Console.Write(symbol);
            Console.WriteLine();
        }

        static int[] createRandomArray(uint lengthArray, int minValue, int maxValue)
        {
            int[] array = new int[lengthArray];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
                array[i] = random.Next(minValue, maxValue);
            return array;
        }

        static int FindFirstArrayIndex(int[] array, int findValue)
        {
            for(int i = 0; i < array.Length; i++)
                if (array[i] == findValue) return i;
            return -1;
        }
    }
}
