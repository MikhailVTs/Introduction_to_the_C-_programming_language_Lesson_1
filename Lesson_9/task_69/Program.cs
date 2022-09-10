// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
// и возводит число А в целую степень B с помощью рекурсии.

// A = 3; B = 5 -> 243
// A = 2; B = 3 -> 8

Console.Clear();

int Exponentiation(int a, int b)
{
    if (b == 0)
    {
        return 1;
    }
    if (a == 0)
    {
        return 0;
    }
    return a * a * Exponentiation(a, b - 1);
}

Console.WriteLine("Введите два числа A и B, для того, чтобы возвести число А в целую степень B.");
Console.WriteLine();
Console.Write("Введите число A: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B: ");
int b = int.Parse(Console.ReadLine()!);

int exponentiation = Exponentiation(a, b);

Console.WriteLine();
Console.WriteLine($"A = {a}; B = {b} -> {exponentiation}");