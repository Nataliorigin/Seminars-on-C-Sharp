
Console.WriteLine("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
while (true)
{
	if (N > 99 && N < 1000)
	{
		int M = N % 10;
		Console.Write("Последняя цифра:" + M);
		break;
	}
	else
	{
		Console.WriteLine("Введите трехзначное число: ");
		N = Convert.ToInt32(Console.ReadLine());
	}
}