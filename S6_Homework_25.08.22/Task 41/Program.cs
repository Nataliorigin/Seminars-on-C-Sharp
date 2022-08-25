// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
int count = Convert.ToInt32(Console.ReadLine());
void EnterNumb(int counter)
{
	int sum = default;
	int num = default;
	for (int i = 0; i < counter; i++)
	{
		Console.WriteLine("Введите число: ");
		num = Convert.ToInt32(Console.ReadLine());
		if (num > 0) sum++;
	}
	Console.WriteLine("Количество чисел больше нуля равно " + sum);
}

EnterNumb(count);