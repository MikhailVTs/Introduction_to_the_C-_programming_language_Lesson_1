// Напишите программу, которая принимае на вход число (N) 
// и выдает таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write($"{number} -> ");

for (int i = 1; i < number; i++)
{
    Console.Write($"{Math.Pow(i, 3)}, ");
}
Console.Write($"{Math.Pow(number, 3)}");

