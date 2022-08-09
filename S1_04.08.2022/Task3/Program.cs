Console.Write("Введите целое число (от 1 до 7): ");
int N = Convert.ToInt32(Console.ReadLine());

while (N < 0 || N > 7)
{
	if (N == 1)
	{
		Console.WriteLine("Понедельник");
	}
	if (N == 2)
	{
		Console.WriteLine("Вторник");
	}
	if (N == 3)
	{
		Console.WriteLine("Среда");
	}
	if (N == 4)
	{
		Console.WriteLine("Четверг");
	}
	if (N == 5)
	{
		Console.WriteLine("Пятница");
	}
	if (N == 6)
	{
		Console.WriteLine("Суббота");
	}
	if (N == 7)
	{
		Console.WriteLine("Воскресенье");
	}
	else
	{
		Console.Write("Введите целое число (от 1 до 7): ");
		N = Convert.ToInt32(Console.ReadLine());
	}
}

