using System;

namespace ReferencTypesHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] myArray = { 1, 2, 3 };
            string[] myArray = { "string", "test", "array" };
            Resize(ref myArray, 5);
            /*
            AddLastElimentToArray(ref myArray, 4);
            AddFirstElimentToArray(ref myArray, 50);
            AddElimentToArray(ref myArray, -5, 2);
            DeleteFirstElimentInArray(ref myArray);
            DeleteLastElimentInArray(ref myArray);
            */

            int[] myArray2 = { 1, 2, 3 };
            DeleteElimentInArray(ref myArray2, 1);


            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

        }

        // 1. Написать метод Resize изменяющий количество элементов массива (метод должен иметь возможность увеличить или уменьшить колличество элементов массива).

        /// <summary>
        /// Метод Resize изменяет количество элементов массива.
        /// </summary>
        /// <param name="array">Метод в котором необходимо изменить размер.</param>
        /// <param name="isAddIndex">true - для добавления элементов массива (false - для удаления).</param>
        /// <param name="countIndex">Число элементов, которые необходимо добавить/удалить</param>
        static void OldResize(ref int[] array, bool isAddIndex, int countIndex)
        {
            int[] newArray;
            if (isAddIndex == true)
            {
                newArray = new int[array.Length + countIndex];
                for (int i = 0; i < array.Length; i++) newArray[i] = array[i];
            }
            else
            {
                if (array.Length >= countIndex)
                    newArray = new int[array.Length - countIndex];
                else
                {
                    Console.WriteLine("Невозможно убрать больше элементов, чем количество элементов в массиве на данный момент.");
                    return;
                }
                for (int i = 0; i < newArray.Length; i++) newArray[i] = array[i];
            }
            array = newArray;
        }

        static void Resize<T>(ref T[] array, uint newLength)
        {
            T[] newArray = new T[newLength];
            if (newLength >= array.Length)
            {
                for(int i = 0; i < array.Length; i++)
                {
                    newArray[i] = array[i];
                }
            }
            else
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = array[i];
                }
            }
            array = newArray;
        }


        // 2. Написать метод для добавления элемента в начало массива, в конец массива и по указанному индексу.

        static void AddLastElimentToArray(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[^1] = value;
            array = newArray;
        }

        static void AddFirstElimentToArray(ref int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = value;
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i + 1] = array[i];
            }
            array = newArray;
        }

        static void AddElimentToArray(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];

            int i = 0;
            for (; i < index; i++) newArray[i] = array[i];
            newArray[i] = value;
            i += 1;
            for (; i < newArray.Length; i++) newArray[i] = array[i - 1];

            array = newArray;
        }

        // 3. Написать метод для удаления первого элемента массива, последнего элемента массиваи элемента по указанному индексу.

        static void DeleteFirstElimentInArray(ref int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
                newArray[i] = array[i + 1];
            array = newArray;
        }

        static void DeleteLastElimentInArray(ref int[] array)
        {
            int[] newArray = new int[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
                newArray[i] = array[i];
            array = newArray;
        }

        static void DeleteElimentInArray(ref int[] array, uint index)
        {
            int[] newArray = new int[array.Length - 1];

            int i = 0;
            for (; i < index; i++) newArray[i] = array[i];
            for (; i < newArray.Length; i++) newArray[i] = array[i + 1];
            array = newArray;
        }

    }
}
