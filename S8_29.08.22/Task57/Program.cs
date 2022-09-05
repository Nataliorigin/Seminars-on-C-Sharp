// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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
void Dictionary(int[,] matrix)
{
	int[] array = new int[matrix.Length];
	int k = 0;
	for (int i = 0; i < matrix.GetLength(0); i++) // строки
	{
		for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
		{
			array[k] = matrix[i, j];
			k++;
		}
	}
	Array.Sort(array);
	int count = 1;
	int value = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] != value)
		{
			Console.WriteLine($"Значение {value} встречается {count} раз(a)");
			value = array[i];
			count = 1;
		}
		else count++;
		
	}
	Console.WriteLine($"Значение {value} встречается {count} раз(a)");
}
int[,] matr = CreateMatrixRndInt(3, 4, 1, 9);
PrintMatrix(matr);
Console.WriteLine();
Dictionary(matr);
