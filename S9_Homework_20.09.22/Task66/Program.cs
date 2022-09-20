// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите 2 целых положительных числа: ");
Console.Write("Число М = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Число N = ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num1, int num2)
{
	int sum = default;
	if (num1 < num2) sum = num1 + SumNumber(num1 + 1, num2);

	if (num1 > num2) sum = num1 + SumNumber(num1 - 1, num2);

	if (num1 == num2) sum = num1;

	return sum;
}

int result = SumNumber(m, n);
Console.WriteLine($"Cумма натуральных элементов в промежутке от {m} до {n} -> {result}");