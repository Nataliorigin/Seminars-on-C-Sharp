// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

// if (num >= 0 && num < 100) Console.WriteLine("Третьей цифры нет"); 
// else {
// 	while (Math.Abs(num) > 999)
// 	{
// 		num = num / 10;
// 	}
// 	Console.WriteLine("Третья цифра числа: " + Math.Abs(num % 10));
// }


// Console.WriteLine("Третья цифра числа: " +
// {
// 	int third_num = num < 100 ? "Третьей цифры нет" : Third(num) % 10

// };
// );

string thirdi = num < 100 ? "Третьей цифры нет" : "Третья цифра числа: "+ Third(num).ToString();
int Third(int number)
{
	while (number > 999)
	{
		number = number / 10;
	}
	return Math.Abs(number % 10);
};

Console.WriteLine( thirdi);