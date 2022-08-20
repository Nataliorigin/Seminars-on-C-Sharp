// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6]-> 36 21

int[] CreateArrayRndInt(int size, int min, int max)
{
	int[] array = new int[size];
	Random rnd = new Random();
	for (int i = 0; i < size; i++)
	{
		array[i] = rnd.Next(min, max + 1);
	}
	return array;
}

void PrintArray(int[] array)
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

int [] ProdPairsNumbers(int[] findarray)
{
	int prod = 0;
	if(findarray.Length%2 ==0) prod = findarray.Length / 2;
	else prod = (findarray.Length / 2) + 1;
	int[] result = new int[prod];
	for (int i = 0; i < findarray.Length/2; i++)
	{
			result[i] = findarray[i] * findarray[findarray.Length -i-1];	
	}
	if(findarray.Length%2 !=0)
		result[prod - 1] = findarray[findarray.Length / 2];
	return result;
}
int[] array = CreateArrayRndInt(5, 1, 9);
PrintArray(array);
int[] array2 = (ProdPairsNumbers(array));
PrintArray(array2);