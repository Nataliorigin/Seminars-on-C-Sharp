// Задача 52.Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
	int[,] matrix = new int[row, col];
	Random rnd = new Random();

	for (int i = 0; i < matrix.GetLength(0); i++) // строки
	{
		for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
		{
			matrix[i, j] = rnd.Next(min, max + 1);
		}
	}
	return matrix;
}
void PrintArray(double[] array)
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
void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write(j < matrix.GetLength(1) - 1 ? //Тернартный оператор
			$"{matrix[i, j]}, " : $"{matrix[i, j]} ");
		}
		Console.WriteLine("]");
	}
}
double[] AverageColumn(int[,] matrix)
{
	double sum = default;
	int сolLength = matrix.GetLength(0);
	int rowLength = matrix.GetLength(1);
	double[] arr = new double[rowLength];
	for (int j = 0; j < rowLength; j++) // столбцы
	{
		for (int i = 0; i < сolLength; i++) // строки
		{
			sum += matrix[i, j];
		}
		arr[j] = Math.Round(sum / сolLength, 2, MidpointRounding.ToZero);
		sum = default;
	}
	return arr;
}

int[,] matr = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matr);
double[] newarr = AverageColumn(matr);
Console.Write($"Среднее арифметическое каждого столбца: ");
PrintArray(newarr);