// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int c = Convert.ToInt32(Console.ReadLine());


bool Triangle(int num1, int num2, int num3)
{
	return num1 + num2 > num3 && num1 + num3 > num2 && num3 + num2 > num1;
}

bool result = Triangle (a, b, c);
Console.WriteLine(result? "Тругольник с такими сторонами существует":"Тругольник с такими сторонами не существует");
