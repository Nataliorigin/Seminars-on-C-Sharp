// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Ряд четных чисел от 1 до N");
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Ряд четных чисел от 1 до N: ");
while (true)
{
	if (num <= 0)
	{
		Console.Write("Ошибка. Введите положительное число: ");
		num = Convert.ToInt32(Console.ReadLine());
	}
	else
	{
		for (int i = 2; i <= num; i += 2)
		{
			Console.Write(i + " ");
		}
		break;
	}
}

