// Напишите программу, которая принимает на вход три числа и выдаёт 
// максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число а: ");
int number_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b: ");
int number_2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число c: ");
int number_3 = int.Parse(Console.ReadLine()!);
int max = number_1;
if(number_1 > max) max = number_1;
if(number_2 > max) max = number_2;
if(number_3 > max) max = number_3;
Console.Write("max = " + max);