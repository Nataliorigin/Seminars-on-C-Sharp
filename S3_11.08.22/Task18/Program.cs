// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти: ");
int result = Convert.ToInt32(Console.ReadLine());

string GetRange (int q)
{
	if (q==1) return "Координаты от [1;+∞]";
	if (q==2) return "Координаты от[-1;+∞]";
	if (q==3) return "Координаты от [1;-∞]";
	if (q==4) return "Координаты от [-1;-∞]";
	return "Введено некорректное значение";
}

string result2 = GetRange (result);
Console.WriteLine(result2);