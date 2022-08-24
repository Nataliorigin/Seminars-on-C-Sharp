// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите целое десятичное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = 0;
int mult = 1;

while (num > 0)
{
	result += num % 2 * mult;
	num /= 2;
	mult *= 10;
}

Console.Write(result);

//Решение с рекурсией
int number = 13;

void DecToBin(int num)
{
	if (num == 0) return;
	DecToBin(num / 2);
	Console.Write(num % 2);
}

DecToBin(number);