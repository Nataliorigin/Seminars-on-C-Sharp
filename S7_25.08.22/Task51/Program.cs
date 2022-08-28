﻿// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1; 1) и т.д.

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

void PrintMatrix(int[,] matrix)
{
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		Console.Write("[");
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			Console.Write(j < matrix.GetLength(1) - 1 ? //Тернартный оператор
			$"{matrix[i, j],4}," : $"{matrix[i, j],4} ");
		}
		Console.WriteLine("]");
	}
}

int MatrixSumElDiagonal(int[,] matrix)
{
	int sum = default;
	for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++) // строки
	{
		sum += matrix[i, i];
	}
	return sum;
}

int[,] array2D = CreateMatrixRndInt(5, 3, 1, 10);
PrintMatrix(array2D);
Console.WriteLine($"Сумма элементов по диагонали: {MatrixSumElDiagonal(array2D)}");
