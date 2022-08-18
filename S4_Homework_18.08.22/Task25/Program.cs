// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4-> 16

Console.Write("Введите число А: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Degree(int number,int number2){
	int num = number;
	if (number2 > 0)
	{
		for (int i = 0; i < number2 - 1; i++)
		{
			number = number * num;
		}
		return number;
	}
	else {
		return -1;
	}
}
if (Degree(num1, num2)==-1)Console.WriteLine("Введены некорректные данные");
else 
Console.WriteLine($"{num1} в степени {num2} :{Degree(num1, num2)}");