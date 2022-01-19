using System;

namespace ReferencTypesHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };
            Resize(ref myArray, true, 10);
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
    }
}
