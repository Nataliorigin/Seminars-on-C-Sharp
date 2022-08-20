// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2]-> 0
// [10, 11, 12, 13, 14]-> 5

int[] CreateArrayRndInt(int size, int min, int max) //Метод для создания массива случайных чисел
{
	int[] array = new int[size];
	Random rnd = new Random();
	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
}
void PrintArray(int[] array)	//Метод для выведения массива
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

int FindElem(int[] randomArray) //Метод для нахождения количества чисел в массиве на отрезке [10,99]
{
	int count = 0;
	for (int i = 0; i < randomArray.Length; i++)
	{
		if (randomArray[i] >=10 && randomArray[i] <= 99)
		{
			count++;
		}
			}
	return count;
}

int[] array = CreateArrayRndInt(5, 1, 100);
PrintArray(array);
Console.WriteLine(FindElem(array));
