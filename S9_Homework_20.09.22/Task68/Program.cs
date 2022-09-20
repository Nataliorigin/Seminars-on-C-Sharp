// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите 2 целых неотрицательных числа: ");
Console.Write("Число m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Число n = ");
int n = Convert.ToInt32(Console.ReadLine());

int Accerman(int m, int n)
{
	if (m == 0) return n = n + 1;
	if (n == 0) return Accerman(m - 1, 1);
	else return Accerman(m - 1, Accerman(m, n - 1));
}

int result = Accerman(m, n);
Console.WriteLine($"A({m},{n}) -> {result}");