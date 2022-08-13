// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Введите координаты точки A: ");
Console.WriteLine("Координата по оси Х: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата по оси Y: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата по оси Z: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
Console.WriteLine("Координата по оси Х: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата по оси Y: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Координата по оси Z: ");
int z2 = Convert.ToInt32(Console.ReadLine());

// double a = x1 - x2;
// double b = y1 - y2;
// double c = z1 - z2;
// double result = Math.Sqrt(a * a + b * b + c * c);
// Console.WriteLine("Расстояние между координатами от точки А до точки В: {0: #.##}", + result); вариант округления числа

// Console.WriteLine("Расстояние между координатами от точки А до точки В: " + Math.Round(result, 2, MidpointRounding.ToZero));

double Distance(int xa1, int ya1, int za1, int xa2,int ya2,int za2)  
{	double aa = xa1 - xa2;
	double bb = ya1 - ya2;
	double cc = za1 - za2;
	double result = Math.Sqrt(aa * aa + bb * bb + cc * cc);
	return Math.Round(result, 2, MidpointRounding.ToZero);
}

double result = Distance(x1, y1, z1,x2, y2, z2);
Console.WriteLine("Расстояние между координатами от точки А до точки В: " + result);