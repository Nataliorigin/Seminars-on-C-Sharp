// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

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

void CreateReverseRowMatrix (int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(1); i++)
	{
		int replacement = matrix[0 , i];
		matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
		matrix[matrix.GetLength(1) - 1, i] = replacement;
	}

}

int[,] matr = CreateMatrixRndInt (4, 5, 1, 10);
PrintMatrix(matr);
Console.WriteLine();
CreateReverseRowMatrix (matr);
PrintMatrix(matr);