using System;

class Project_3
{
	private static Random rand = new Random();

	private static int[] Initialize()
	{
		int size;
		do
		{
			Console.Write("Введите размер массива: ");
			size = Convert.ToInt32(Console.ReadLine());
		} while (size <= 0);

		int[] array = new int[size];
		for (int i = 0; i < array.Length; i++)
			array[i] = rand.Next(0, 100);
		return array;
	}

	private static void Print(int[] array)
	{
		Console.Write("Массив: ");
		foreach (int index in array)
			Console.Write(index + " ");
		Console.WriteLine();
	}

	private static int[] Add(int[] array1, int[] array2)
	{
		if (array1.Length != array2.Length)
		{
			Console.WriteLine("Массивы разных размеров");
			return array1;
		}
		int[] value = new int[array1.Length];

		for (int index = 0; index < value.Length; index++)
			value[index] = array1[index] + array2[index];
		return value;
	}

	private static int[] Multiply(int[] array, int number)
	{
		int[] value = new int[array.Length];
		Array.Copy(array, value, array.Length);

		for (int index = 0; index < value.Length; index++)
			value[index] = array[index] * number;

		return value;
	}

	private static void Sort(ref int[] array)
	{
		for (int i = 0; i < array.Length; i++)
		{
			for (int j = i; j < array.Length; j++)
			{
				if (array[j] > array[i])
				{
					int temp = array[i];
					array[i] = array[j];
					array[j] = temp;
				}
			}
		}
	}

	private static string SearchIdentical(int[] array1, int[] array2)
	{
		string value = "";
		for (int i = 0; i < array1.Length; i++)
		{
			for (int j = 0; j < array2.Length; j++)
			{
				if (array1[i] == array2[j])
					value += array1[i] + " ";
			}
		}
		if (value.Length == 0)
		{
			Console.WriteLine("Общие значения не найдены");
			return "";
		}
		return value;
	}

	private static int Min(int[] array)
	{
		int min = 0;
		foreach (int index in array)
		{
			if (index < min)
				min = index;
		}
		return min;
	}

	private static int Max(int[] array)
	{
		int max = 0;
		foreach (int index in array)
		{
			if (index > max)
				max = index;
		}
		return max;
	}

	private static float Average(int[] array)
	{
		float sum = 0, count = 0;
		foreach (int index in array)
		{
			sum += index;
			count++;
		}
		return sum / count;
	}

	static void Main()
	{
		int mode, array_switch = 1;
		int[] array1 = null;
		int[] array2 = null;

		while (true)
		{
			do
			{
				Console.WriteLine("0 - Выход");
				Console.WriteLine("1 - Инициализация массива");
				Console.WriteLine("2 - Сложение массивов");
				Console.WriteLine("3 - Умножение массива на число");
				Console.WriteLine("4 - Поиск общих значений в двух массивов");
				Console.WriteLine("5 - Печать массива");
				Console.WriteLine("6 - Сортировка по убыванию");
				Console.WriteLine("7 - Поиск минимума в массиве");
				Console.WriteLine("8 - Поиск максимума в массиве");
				Console.WriteLine("9 - Поиск среднего значения в массиве");
				Console.WriteLine($"10 - Смена массива {array_switch}");
				mode = Convert.ToInt32(Console.ReadLine());
			} while (mode < 0);

			switch (mode)
			{
				case 0:
					return;
				case 1:
					Console.WriteLine();
					if (array_switch == 1)
						array1 = Initialize();
					else if (array_switch == 2)
						array2 = Initialize();
					Console.WriteLine();
					break;
				case 2:
					Console.WriteLine();
					if (array1 == null || array2 == null)
					{
						Console.WriteLine("Необходимо проинициализировать 2 массива");
						break;
					}
					int[] res = Add(array1, array2);
					if (res != array1)
						Print(res);
					Console.WriteLine();
					break;
				case 3:
					Console.WriteLine();
					if (array_switch == 1 && array1 == null || array_switch == 2 && array2 == null)
					{
						Console.WriteLine("Необходимо проинициализировать массив");
						Console.WriteLine();
						break;
					}

					int input = 0;
					Console.WriteLine("Введите число, на которое необходимо умножить массив");
					do
					{
						input = Convert.ToInt32(Console.ReadLine());
						break;
					} while (true);

					if (array_switch == 1)
						Print(Multiply(array1, input));
					else if (array_switch == 2)
					{
						Print(Multiply(array2, input));
					}
					Console.WriteLine();
					break;
				case 4:
					Console.WriteLine();
					if (array1 == null || array2 == null)
					{
						Console.WriteLine("Необходимо проинициализировать 2 массива");
						Console.WriteLine();
						break;
					}
					string idential = SearchIdentical(array1, array2);
					if (idential.Length == 0)
					{
						Console.WriteLine("Общие значения не найдены");
						break;
					}
					Console.WriteLine($"Общие значения: {idential}");
					Console.WriteLine();
					break;
				case 5:
					Console.WriteLine();
					if (array_switch == 1)
					{
						if (array1 == null)
						{
							Console.WriteLine("Необходимо проинициализировать массив\n");
							break;
						}
						Print(array1);
					}
					else
					{
						if (array2 == null)
						{
							Console.WriteLine("Необходимо проинициализировать массив\n");
							break;
						}
						Print(array2);
					}
					Console.WriteLine();
					break;
				case 6:
					Console.WriteLine();
					if (array_switch == 1)
					{
						if (array1 == null)
						{
							Console.WriteLine("Необходимо проинициализировать массив");
							Console.WriteLine();
							break;
						}
						Console.WriteLine("Отсортированный массив:");
						Sort(ref array1);
						Print(array1);
					}
					else if (array_switch == 2)
					{
						if (array2 == null)
						{
							Console.WriteLine("Необходимо проинициализировать массив");
							Console.WriteLine();
							break;
						}
						Console.WriteLine("Отсортированный массив:");
						Sort(ref array2);
						Print(array2);
					}
					Console.WriteLine();
					break;
				case 7:
					Console.WriteLine();
					if (array_switch == 1)
					{
						if (array1 == null)
						{
							Console.WriteLine("Необходимо проинициализировать массив");
							Console.WriteLine();
							break;
						}
						Console.WriteLine($"Минимум в массиве: {Min(array1)}");
					}
					else if (array_switch == 2)
					{
						if (array2 == null)
						{
							Console.WriteLine("Необходимо проинициализировать массив");
							Console.WriteLine();
							break;
						}
						Console.WriteLine($"Минимум в массиве: {Min(array2)}");
					}
					Console.WriteLine();
					break;
				case 8:
					Console.WriteLine();
					if (array_switch == 1)
					{
						if (array1 == null)
						{
							Console.WriteLine("Необходимо проинициализировать массив");
							Console.WriteLine();
							break;
						}
						Console.WriteLine($"Максимум в массиве: {Max(array1)}");
					}
					else if (array_switch == 2)
					{
						if (array2 == null)
						{
							Console.WriteLine("Необходимо проинициализировать массив");
							Console.WriteLine();
							break;
						}
						Console.WriteLine($"Максимум в массиве: {Max(array2)}");
					}
					Console.WriteLine();
					break;
				case 9:
					Console.WriteLine();
					if (array_switch == 1)
					{
						if (array1 == null)
						{
							Console.WriteLine("Необходимо проинициализировать массив");
							Console.WriteLine();
							break;
						}
						Console.WriteLine($"Среднее значение в массиве: {Average(array1)}");
					}
					else if (array_switch == 2)
					{
						if (array2 == null)
						{
							Console.WriteLine("Необходимо проинициализировать массив");
							Console.WriteLine();
							break;
						}
						Console.WriteLine($"Среднее значение в массиве: {Average(array2)}");
					}
					Console.WriteLine();
					break;
				case 10:
					Console.WriteLine("1 - Массив 1");
					if (array1 == null)
						Console.WriteLine("Массив не инициализирован");
					Console.WriteLine("2 - Массив 2");
					if (array2 == null)
						Console.WriteLine("Массив не инициализирован");
					do
					{
						array_switch = Convert.ToInt32(Console.ReadLine());
					} while (array_switch != 1 && array_switch != 2);
					Console.WriteLine();
					break;
				default:
					Console.WriteLine("\nНеизвестная команда!\n");
					break;
			}
		}
	}
}