using System;

namespace fastTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";
            ref string s2 = ref s;
            Console.WriteLine(s2);
            s = "world";
            Console.WriteLine(s2);

            int[] a = { 0 };
            int[] a2 = a;
            Console.WriteLine(a2[0]);
            a[0] = 1488;
            Console.WriteLine(a2[0]);

        }
    }
}
