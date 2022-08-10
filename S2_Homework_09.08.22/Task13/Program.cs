// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 0 && num < 100) Console.WriteLine("Третьей цифры нет"); 
else {
	while (Math.Abs(num) > 999)
	{
		num = num / 10;
	}
	Console.WriteLine("Третья цифра числа: " + Math.Abs(num % 10));
}


