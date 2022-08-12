// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21

Console.WriteLine("Введите координаты точки A: ");
Console.WriteLine("Координата по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.WriteLine("Координата по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double a = x1 - x2;
double b = y1 - y2;
double result = Math.Sqrt(a*a + b*b);
// Console.WriteLine("Расстояние между координатами от точки А до точки В: {0: #.##}", + result); вариант округления числа

Console.WriteLine("Расстояние между координатами от точки А до точки В: " + Math.Round(result, 2, MidpointRounding.ToZero));
