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
            int index = 0;
            PrintRecursion(myArray, ref index);  // вывод массива с помощью рекурсии

            index = 0;
            int sum = 0;
            int sumArray = SumRecursion(myArray, ref index, ref sum); // сумма элементов массива с помощью рекурсии
            Console.WriteLine(sumArray);

            int value = 555;
            index = 0;
            int sumDigital = 0;
            Console.WriteLine(SumDigital(value, ref index, ref sumDigital));
        }


        // Реолизовать вывод массива с помощью рекурсии.
        static void PrintRecursion(int[] array, ref int i)
        {
            if (i < array.Length)
            {
                Console.WriteLine(array[i]);
                i++;
                PrintRecursion(array, ref i);
            }
        }

        // Найти сумму элементов массива с помощью рекурсии.
        static int SumRecursion(int[] array, ref int i, ref int sum)
        {
            sum += array[i];
            i++;
            if (i < array.Length)
            {
                SumRecursion(array, ref i, ref sum);
            }
            return sum;
        }

        // Найти сумму цифр числа с помощью рекурсии.
        static int SumDigital(int value, ref int i, ref int sumDigital)
        {
            string stringValue = value.ToString();
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
