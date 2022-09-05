// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7->такого элемента в массиве нет
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
void FindElementByPosition(int[,] matrix)
{
	Console.WriteLine("Введите индекс строки: ");
	int x = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Введите индекс столбца: ");
	int y = Convert.ToInt32(Console.ReadLine());
	if (x < matrix.GetLength(0) && y < matrix.GetLength(1))
	{
		for (int i = 0; i < matrix.GetLength(0); i++) // строки
		{
			for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
			{
				if (i == x && j == y)
				{
					Console.Write($"Элемент: {matrix[i, j]}");
				}
			}
		}
	}
	else Console.Write("Элемента не существует");
}

int[,] matrica = CreateMatrixRndInt(5, 4, 1, 10);
PrintMatrix(matrica);
FindElementByPosition(matrica);