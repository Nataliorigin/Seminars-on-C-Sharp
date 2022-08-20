// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6]-> 0

void MasRandom(int[] array) //Метод для: Создаем массив с рандомными двухзначными положительными числами
{
	Random rmd = new Random();
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = rmd.Next(-10, 100);
	}
}
void PrintArray(int[] array)  //Метод для: Выводим массив в консоль
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		if (i < array.Length - 1) Console.Write($"{array[i]},");
		else Console.Write(array[i]);
	}
	Console.Write("]");
	Console.WriteLine();
}
int SumГnevenElem(int[] array) //Метод для: Сумма чисел на нечетных позициях
{
	int sumEl = 0;

	for (int i = 1; i < array.Length; i += 2)
	{
		sumEl = array[i] + sumEl;
	}
	return sumEl;
}
int[] newarray = new int[5];
MasRandom(newarray);
Console.Write($"Массив: ");
PrintArray(newarray);
Console.Write($"Сумма чисел на нечетных позициях: {SumГnevenElem(newarray)}.");