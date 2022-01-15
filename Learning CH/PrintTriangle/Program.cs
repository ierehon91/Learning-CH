using System;

namespace PrintTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите размер треугольника: ");
            int triangleSize = Int32.Parse(Console.ReadLine());
            PrintTriangle1(triangleSize);
            Console.WriteLine();
            PrintTriangle2(triangleSize);
            Console.WriteLine();
            PrintTriangle3(triangleSize);
            Console.WriteLine();
            PrintTriangle4(triangleSize);
        }

        static void PrintTriangle1(int triangleSize)
        {
            for (int i = 0; i < triangleSize; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangle2(int triangleSize)
        {
            for (int i = 0; i < triangleSize; i++)
            {
                for (int j = triangleSize; j > i; j--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangle3(int triangleSize)
        {
            for (int i = 0; i < triangleSize; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = triangleSize - 1; k >= i; k--)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

        static void PrintTriangle4(int triangleSize)
        {
            for (int i = 0; i < triangleSize; i++)
            {
                for (int j = triangleSize - 1; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
