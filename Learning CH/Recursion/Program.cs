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
            PrintRecursion(myArray);  // вывод массива с помощью рекурсии

            int sumArray = SumRecursion(myArray); // сумма элементов массива с помощью рекурсии
            Console.WriteLine(sumArray);
        }


        // Реолизовать вывод массива с помощью рекурсии.
        static void PrintRecursion(int[] array, int i = 0)
        {
            if (i < array.Length)
            {
                Console.WriteLine(array[i]);
                i++;
                PrintRecursion(array, i);
            }
        }

        // Найти сумму элементов массива с помощью рекурсии.
        static int SumRecursion(int[] array, int i = 0, int sum = 0)
        {
            sum += array[i];
            i++;
            if (i < array.Length)
            {
                SumRecursion(array, i, sum);
            }
            return sum;

        }
    }
}
