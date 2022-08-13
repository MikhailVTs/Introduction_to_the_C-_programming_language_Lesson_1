// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.WriteLine("Введите три числа!");

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

if (a > b && b > c) 
{
    Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {a}");
}

else if (a < b && b > c) 
{
    Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {b}");
}
else 
{
    Console.WriteLine($"a = {a}; b = {b}; c = {c} -> max = {c}");
}