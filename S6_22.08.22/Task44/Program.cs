// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите целое число N: ");
int n = Convert.ToInt32(Console.ReadLine());
void Fibonachi(int count)
{
	int num1 = 0;
	int num2 = 1;
	Console.Write(num1 + " " + num2 + " ");
	for (int i = 2; i < count; i++)
			{
		int temp = num1 + num2;
		num1 = num2;
		num2 = temp;
		Console.Write(temp+" ");
	}
}
Fibonachi(n);