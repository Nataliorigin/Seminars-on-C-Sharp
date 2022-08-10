// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число дня недели: ");
int den_nedeli = Convert.ToInt32(Console.ReadLine());
while (true)
{
	if (den_nedeli > 0 && den_nedeli < 8)
	{
		if (den_nedeli == 6 || den_nedeli == 7)
		{
			Console.WriteLine("Ура, выходной!");
			break;
		}
		else
		{
			Console.WriteLine("Это рабочий день :(");
			break;
		}
	}
	else
	{
		Console.Write("Ошибка. Введите число дня недели от 1 до 7: ");
		den_nedeli = Convert.ToInt32(Console.ReadLine());
	}
}

