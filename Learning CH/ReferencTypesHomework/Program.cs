using System;

namespace ReferencTypesHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };
            Resize(ref myArray, true, 1);
            AddLastElimentToArray(ref myArray, 4);
            AddFirstElimentToArray(ref myArray, 50);
            AddElimentToArray(ref myArray, -5, 2);
            foreach (int i in myArray)
            {
                Console.WriteLine(i);
            }

        }

        /// <summary>
        /// Метод Resize изменяет количество элементов массива.
        /// </summary>
        /// <param name="array">Метод в котором необходимо изменить размер.</param>
        /// <param name="isAddIndex">true - для добавления элементов массива (false - для удаления).</param>
        /// <param name="countIndex">Число элементов, которые необходимо добавить/удалить</param>
        static void Resize(ref int[] array, bool isAddIndex, int countIndex)
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

    }
}
