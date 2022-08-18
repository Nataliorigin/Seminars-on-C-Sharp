// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 1;
// if (num > 0)
// {
// 	for (int i = 1; i <= num; i++)
// 	{
// 		sum = sum * i;
// 	}
// 	Console.WriteLine($"Произведение чисел от 1 до {num} равно {sum}");
// }
// else
// {
// 	Console.WriteLine($"Некорректные данные.Введите положительное число");
// }

int Product(int number){
	
	for (int i = 1; i <= number; i++)
		{
			sum = sum * i;
		}
	return sum;
}

	Console.WriteLine($"Произведение чисел от 1 до {num} равно {Product(num)}");