using System;

namespace DoubleAndDecimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double d1 = 0.1;
            double d2 = 0.2;

            System.Console.WriteLine($"Double: {d1 + d2 == 0.3} ({d1 + d2})");

            decimal m1 = 0.1m;
            decimal m2 = 0.2m;

            System.Console.WriteLine($"Decimal: {m1 + m2 == 0.3m} ({m1 + m2})");

        }
    }
}
