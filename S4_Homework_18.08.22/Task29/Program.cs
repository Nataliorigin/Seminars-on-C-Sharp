// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33-> [6, 1, 33]

void ArrayRandom(int[] array)
{
	Random rmd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rmd.Next(1, 100);
	}
}

void PrintArray(int[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write(array[i] + ",");
		else Console.Write(array[i]);
	}
	Console.Write("]");
}

Console.WriteLine("Случайный массив из чисел от 1 до 99:");
int[] randomarray = new int[8];
ArrayRandom(randomarray);
PrintArray(randomarray);