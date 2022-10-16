// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Enter number: ");
int number = int.Parse(Console.ReadLine()!);
int a = 2;
if(number > 1) // Было: + Console.Write(a + " "); работало при n-1 в while - громоздко
    while(number >= a)
        {
            Console.Write(a + " ");
            a = a + 2;
        }
if(number <= 1) Console.WriteLine("Wrong input");
