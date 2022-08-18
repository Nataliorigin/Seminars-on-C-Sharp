// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumbers (int number)
{number = Math.Abs(number);
int sum = 0;
int input = number;

	while (input != 0)
	{
		number = input % 10;
		sum = sum + number;
		input = input / 10;
	}
	return sum;
}
Console.WriteLine("Cумма цифр в числе: " + SumNumbers(num));