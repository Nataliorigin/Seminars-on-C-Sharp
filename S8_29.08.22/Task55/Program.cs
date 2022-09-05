// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

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
			$"{matrix[i, j]}, " : $"{matrix[i, j]} ");
		}
		Console.WriteLine("]");
	}
}

int [,] NewMatrix (int [,] matrix)
{	int[,] matr = new int[matrix.GetLength(0),matrix.GetLength(1)];
	for (int i = 0; i < matrix.GetLength(0); i ++) // строки
	{
		for (int j = 0; j < matrix.GetLength(1); j ++) // столбцы
		{	
			matr [i, j] = matrix[j, i];
			
		}
	}
	return matr;
}

int[,] matr = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(matr);
Console.WriteLine();
int[,] matrixTwo = NewMatrix(matr);
PrintMatrix(matrixTwo);