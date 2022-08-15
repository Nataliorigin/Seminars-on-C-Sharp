// 11.Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(99, 1000);
Console.WriteLine("Трехзначное число: " + num);
int first_num = num / 100;
int second_num = num % 10;
int result = first_num * 10 + second_num;
Console.WriteLine($"Ответ: " + result);