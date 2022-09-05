// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
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

int MinElem(int[,] matrix)
{
	int min = matrix[0, 0];
	int row = 0;
	int col = 0;
	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			if (matrix[i, j] < min)
			{
				min = matrix[i, j];
				row = i;
				col = j;
			}
		}
	}
	return min;
}

int[,] matrix = CreateMatrixRndInt(3, 4, 0, 5);
PrintMatrix(matrix);
int temp = MinElem(matrix);
Console.WriteLine(temp);
