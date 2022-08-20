// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] MasRandom(int size, int min, int max) //Метод для: Создаем массив с рандомными трехзначными положительными числами
{
	int[] array = new int[size];
	Random rnd = new Random();
	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
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

int EvenElem(int[] randomArray) //Метод для: Подсчет количества четных чисел в массиве
{
	int count = 0;
	for (int i = 0; i < randomArray.Length; i++)
	{
		if (randomArray[i] % 2 == 0)
		{
			count++;
		}
	}
	return count;
}

int [] newarray = MasRandom(4, 100, 999);
Console.Write($"Количество четных элементов в массиве ");
PrintArray(newarray);
Console.Write($"Ответ: {EvenElem(newarray)}.");
