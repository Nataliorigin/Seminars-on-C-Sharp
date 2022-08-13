// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. 
//Если есть желание, написать палидром для любого размера числа.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Прямое решение:

// if (num > 9999 && num < 100000)
// {
// 	if (num / 10000 == num % 10 && num % 100 / 10 == num % 10000 / 1000)
// 	{
// 		Console.WriteLine("Число является палидромом");
// 	}
// 	else
// 	{
// 		Console.WriteLine("Число не является палидромом");
// 	}
// }
// else{
// 	Console.WriteLine($"Введены некорректные данные");
// }

//Решение с функцией и тернарным оператором:
Console.WriteLine("Введите пятизначное число: ");
 int num = (Convert.ToInt32(Console.ReadLine()));
string Palidrome(int number){
	string result =  number > 9999 && number < 100000 ? 
number / 10000 == number % 10 && number % 100 / 10 == number % 10000 / 1000 ? "Число является палидромом" : "Число не является палидромом" : "Введены некорректные данные";
return result;
}

Console.WriteLine(Palidrome(num));

//Решение с функцией для числа с любой размерностью:

// int Palindrome(int number)
// {
// 		int n = number;
// 	int revers = 0;
// 	while ( n % 10 != 0)
// 	{
// 		int r = n % 10;
// 		revers = revers * 10 + r;
// 		n = n / 10;
// 	}
// if(number == revers) return 1;
// else return 0;
// }
// Console.WriteLine("Введите число: ");
// int num = (Convert.ToInt32(Console.ReadLine()));
// { if (Palindrome(num) == 0 || Palindrome(num) == 1)
// 	{
// 		if (Palindrome(num) == 1)
// 		{
// 			Console.WriteLine("Число является палидромом");
// 		}
// 		if (Palindrome(num) == 0)
// 		{
// 			Console.WriteLine("Число не является палидромом");
// 		}
// 	}
// 	else
// 		Console.WriteLine("Введены некорректные данные");

// }