// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write(" Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

//int input = num;
//int count = 0;
// while (num > 0)
// {
// 	num /= 10;
// 	count++;
// }
// Console.Write($" Число {input} имеет количество цифр равное {count} ");

int Numbers(int number)
{
	if (number < 0) return -1;
	int input = number;
	int count = 0;
	for (; number > 0; count++)
	{
		number /= 10;
	}
	return count;
}

if (Numbers(num) == -1) Console.Write("Некорректные данные. Введите положительное число");

Console.Write($" Число {num} имеет количество цифр равное {Numbers(num)} ");