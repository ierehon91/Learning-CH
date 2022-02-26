using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunFactorial(15);
        }

        static int Factorial( int num )
        {
            if (num < 1)
            {
                return 0;
            }
            
            else if (num == 1)
            {
                return 1;
            }

            else
            {
                checked
                {
                    return num * Factorial(num - 1);
                }
            }
        }

        static void RunFactorial( int num )
        {
            if ( num <= 15)
            {
                for (int i = 0; i < num; i++)
                {
                    try
                    {
                        Console.WriteLine($"{i}! = {Factorial(i)}");
                    }
                    catch (System.OverflowException)
                    {
                        Console.WriteLine($"{i}! = Ошибка переполнения!");
                    }
                    
                }
            }
            else
            {
                Console.WriteLine("Максимальное число для которого выполняется подсчёт факториала = 15");
            }
        }
    }
} 
