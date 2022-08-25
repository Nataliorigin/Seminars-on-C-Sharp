// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

// Если система уравнений:

// имеет единственное решение, то прямые пересекаются;
// имеет бесконечное множество решений, то прямые совпадают;
// не имеет решений, то прямые не пересекаются (прямые параллельны между собой) 

Console.Write("Введите точку b1: ");
double num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку k1: ");
double num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку b2: ");
double num3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку k2: ");
double num4 = Convert.ToInt32(Console.ReadLine());


void IntersectionPoint(double b1, double k1, double b2, double k2)
{
	double x1 = default;
	double y1 = default;
	if (k1 != k2)
	{
		x1 = (b1 - b2) / -(k1 - k2);
		y1 = k2 * x1 + b2;
		Console.Write($"({x1};{y1})");
	}
	else Console.Write("Прямые не пересекаются либо имеют множество значений");
}

IntersectionPoint(num1, num2, num3, num4);
	
