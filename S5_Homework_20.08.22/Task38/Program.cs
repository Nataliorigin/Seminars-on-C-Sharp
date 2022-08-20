// Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
void MasRandom(double[] array) //Метод для: Создаем массив вещественных чисел
{
	Random rmd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = Math.Round(rmd.NextDouble() * 50, 1, MidpointRounding.ToZero);
	}
}
void PrintArray(double[] array)  //Метод для: Выводим массив в консоль
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]}, ");
		else Console.Write(array[i]);
	}
	Console.Write("]");
	Console.WriteLine();
}
double DifferenceMinMax(double[] array) //Метод для: Разница между максимальным и минимальным числом
{
	double min = array[0];
	double max = array[0];

	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] > max)
		{
			max = array[i];
		}
		else if (array[i] < min)
		{
			min = array[i];
		}
	}
	return Math.Round(max - min, 1, MidpointRounding.ToZero);
}
double[] newarray = new double[5];
MasRandom(newarray);
Console.Write($"Случайный массив вещественных чисел: ");
PrintArray(newarray);
Console.Write($"Разница между максимальным и минимальным числом массива: {DifferenceMinMax(newarray)}.");
