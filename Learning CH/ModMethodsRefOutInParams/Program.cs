using System;

namespace ModMethodsRefOutInParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            RefMod(ref a);

            OutMod(out int b);
            Console.WriteLine($"b : {b}");
            
        }

        static void RefMod(ref int a)
        {
            a++;
            Console.WriteLine($"a : {a}");
        }

        static void OutMod(out int b)
        {
            b = 10;
            b--;
        }
    }
}
