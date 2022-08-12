Console.WriteLine("Таблица квадратов чисел от 1 до N");
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{

	for (int i = 1; i <= num; i++)
{
	Console.WriteLine($"{i} \t {i * i}");
}
}
else 
Console.WriteLine("Введено некорректное значение");




