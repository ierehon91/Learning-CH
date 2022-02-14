/*  1. Реолизовать вывод массива с помощью рекурсии.
 *  2. Найти сумму элементов массива с помощью рекурсии.
 *  3. Найти сумму цифр числа с помощью рекурсии.
*/

using System;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            int value = 125;

            PrintRecursion(myArray);  // вывод массива с помощью рекурсии
            Console.WriteLine("Сумма элементов массива: " + SumRecursion(myArray));  // сумма элементов массива с помощью рекурсии
            Console.WriteLine($"Сумма цифр числа {value}: {SumDigital(value)}"); // сумма цифр числа с помощью рекурсии
        }


        // Реолизовать вывод массива с помощью рекурсии.
        static void PrintRecursion(int[] array)
        {
            Console.Write("Массив: ");
            int i = 0;
            DoPrintRecursion(array, ref i);

            static void DoPrintRecursion(int[] array, ref int i)
            {
                if (i < array.Length)
                {
                    Console.Write(array[i] + " ");
                    i++;
                    DoPrintRecursion(array, ref i);
                }
            }
            Console.WriteLine();
        }

        // Найти сумму элементов массива с помощью рекурсии.
        static int SumRecursion(int[] array)
        {
            int i = 0;
            int sum = 0;
            CalculateSumRecursion(array, ref i, ref sum);

            static void CalculateSumRecursion(int[] array, ref int i, ref int sum)
            {
                sum += array[i];
                i++;
                if (i < array.Length)
                {
                    CalculateSumRecursion(array, ref i, ref sum);
                }
            }
            
            return sum;
        }

        // Найти сумму цифр числа с помощью рекурсии.
        static int SumDigital(int value)
        {
            string stringValue = value.ToString();
            int i = 0;
            int sumDigital = 0;

            CalculateSumDigital(stringValue, ref i, ref sumDigital);

            static void CalculateSumDigital(string value, ref int i, ref int sumDigital)
            {
                char elimentValue = value[i];
                sumDigital += int.Parse(elimentValue.ToString());
                i++;
                if (i < value.Length)
                {
                    CalculateSumDigital(value, ref i, ref sumDigital);
                }
            }
            return sumDigital;
        }

    }
}
