using System;
using System.Linq;

namespace ArrayLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
			LearningArray();
			HomeWorkArray();

            Console.WriteLine();

			Console.Write("Укажите число строк массива: ");
			int y = int.Parse(Console.ReadLine());

			Console.Write("Укажите число столбцов массива: ");
			int x = int.Parse(Console.ReadLine());

			int[,] myArray = new int[y, x];
			// ReadFromConsole(ref myArray);
			ReadDoubleArray(myArray, 0, 100);
			PrintDoubleArray(myArray);

			Console.ReadLine();
		}

		static void LearningArray()
		{
			// Создаём массив имён типа string длинной 4
			string[] names;
			names = new string[4];
			names[0] = "Jhon";
			names[1] = "Tom";
			names[2] = "Mike";
			names[3] = "Anna";

			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine(names[i]);
			}

			// Создаём массив с длинной 10 и значениями 5 по умолчанию
			int[] digitalsArray = Enumerable.Repeat(5, 10).ToArray();
			foreach (int digital in digitalsArray)
			{
				Console.WriteLine(digital);
			}

			// Создадим массив с длинной 5 и значениями, начиная с 11
			int[] rangeArray = Enumerable.Range(11, 5).ToArray();

			foreach (int rangeDigital in rangeArray)
			{
				Console.WriteLine(rangeDigital);
			}
		}

		static void HomeWorkArray()
		{
			Console.Write("Укажите размер массива: ");
			int countArray = int.Parse(Console.ReadLine());

			int[] myArray = new int[countArray];
			// Ввод значений массива с клавиатуры.
			for (int i = 0; i < myArray.Length; i++)
			{
				System.Console.Write($"Заполните чилом индекс {i} из {countArray - 1} массива: ");
				myArray[i] = Int32.Parse(Console.ReadLine());
			}
			Console.WriteLine();

			// Вывести массив в обратном порядке
			System.Console.Write("Вывод массива в обратном порядке: ");
			for (int i = myArray.Length - 1; i >= 0; i--)
			{
				Console.Write(myArray[i] + "\t");
			}
			Console.WriteLine();

			// Найти сумму чётных чисел в массиве
			int evenCount = 0;
			for (int i = 0; i < myArray.Length; i++)
			{
				if (myArray[i] % 2 == 0) evenCount += myArray[i];
			}
			Console.WriteLine($"Сумма чётных чисел в массиве = {evenCount}");

			// ИЛИ
			Console.WriteLine($"Сумма чётных чисел в массиве = {myArray.Where(i => i % 2 == 0).Sum()} (метод)");

			// Найти наименьшее число в массиве
			int minValue = myArray[0];
			for (int i = 1; i < myArray.Length; i++)
			{
				if (minValue >= myArray[i]) minValue = myArray[i];
			}
			Console.WriteLine($"Наименьшее число в массиве = {minValue}");
			// ИЛИ
			Console.WriteLine($"Сумма чётных чисел в массиве = {myArray.Min()} (метод)");

			// Создать массив без повторяющихся значений
			int[] distinctArray = myArray.Distinct().ToArray();
			Console.Write("Массив с уникальными значениями:");
			foreach (int distinctValue in distinctArray)
			{
				Console.Write($" {distinctValue}");
			}
			Console.WriteLine();

			// Сортируем массив
			int[] sortArray = myArray.OrderBy(i => i).ToArray();
			Console.Write("Массив с отсартированными значениями:");
			foreach (int sortValue in sortArray)
			{
				Console.Write($" {sortValue}");
			}

			int[] sortArrayByDescending = myArray.OrderByDescending(i => i).ToArray(); // сортировка массива в обратном порядке

			// статические методы Array
			int firstFindValue = Array.Find(myArray, i => i < 0); // вернёт первое значение из массива со значением меньше 0
			int lastFindValue = Array.FindLast(myArray, i => i < 0); // вернёт последнее значение из массива со значением меньше 0
			int[] allFindValue = Array.FindAll(myArray, i => i < 0); // вернёт массив значений из массива со значением меньше 0


			// индексы и диапазоны в С# 8
			Index lastIndex = ^1;
			int lastValue = myArray[lastIndex]; // вернёт последнее значение

			Index myIndex = new Index(3, true);
			int threeLastIndex = myArray[myIndex]; // вернёт 3 значение с конца

			Range myRange = new Range(1, 4);
			int[] newArray = myArray[myRange]; // вернёт массив с диапазоном с 1 по 4(не включительно) индекса массива myArray
		}

		static void ReadDoubleArray(int[,] array)
		// заполнение массива с консоли
		{
			int height = array.GetLength(0);
			int width = array.GetLength(1);

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					Console.Write($"Y{i}, X{j} = ");
					array[i, j] = int.Parse(Console.ReadLine());
				}
			}
		}

		static void ReadDoubleArray(int[,] array, int min, int max)
		{
			int height = array.GetLength(0);
			int width = array.GetLength(1);

			Random random = new Random();

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					array[i, j] = random.Next(min, max);
				}
			}
		}

		static void PrintDoubleArray(int[,] array)
		// вывод на консоль в табличном виде
		{
			System.Console.WriteLine();
			int height = array.GetLength(0);
			int width = array.GetLength(1);

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					System.Console.Write($"{array[i, j]}\t");
				}
				System.Console.WriteLine();
			}
		}
	}
}
