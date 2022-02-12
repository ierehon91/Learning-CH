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

            Console.WriteLine(ParamsMod(10, 15, 1));
            
        }

        static void RefMod(ref int a)
        {
            // Модицикатор ref позволяет передавать переменные со значемыми типами по ссылке, а не копируя их.
            a++;
            Console.WriteLine($"a : {a}");
        }

        static void OutMod(out int b)
        {
            // Модификатор out требует обязательную инициализацию переданной переменной в метод
            b = 10;
            b--;
        }

        static void InMod(in int a)
        {
            // Модификатор in позволяет передать значение по ссылке, но не позволяет изменять это значение
            // a = 15 -> ошибка при компиляции
            Console.WriteLine(a);
        }

        static int ParamsMod(params int[] parameters)
        {
            // Модификатор params позволяет передать разное количество параметров в метод.
            // Такой модификатор в методе должен быть один.
            // Если есть другие параметры, то они должны стоять перед параметром с модификатором params.
            int sum = 0;
            for (int i = 0; i < parameters.Length; i++)
            {
                sum += parameters[i];
            }
            return sum;
        }
    }
}
