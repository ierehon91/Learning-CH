using System;

namespace Inheritance_protected_mod
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine(a.publicField);
            // Console.WriteLine(a.privateField); // ошибка доступа
            // Console.WriteLine(a.protectedField); // ошибка доступа
        }
    }

    class A
    {
        public int publicField = 1;
        private int privateField = 2;
        protected int protectedField = 3;
    }

    class B : A
    {
        public void PrintB()
        {
            Console.WriteLine(publicField);
            // Console.WriteLine(privateField); // ошибка доступа
            Console.WriteLine(protectedField);
        }
    }
}
