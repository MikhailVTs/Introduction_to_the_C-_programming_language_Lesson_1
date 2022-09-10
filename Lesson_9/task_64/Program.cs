// Задача 64: Задайте значения M и N. Напишите программу, 
// которая найдет сумму чисел от M до N.

// M = 1; N = 5. -> 1, 2, 3, 4, 5
// M = 4; N = 8. -> 4, 6, 7, 8

Console.Clear();

int SumOfNumbers(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return n + SumOfNumbers(m, n - 1);
}

void PrintFromMToN (int m, int n)
{
    while (m != n+1)
    {
        Console.Write($"{m}, ");
        m++;
    }
    Console.Write("\b");
    Console.Write("\b");
}

Console.WriteLine("Введите диапозон чисел от M до N, для нахождения суммы чисел от M до N.");
Console.WriteLine();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int sumNumber = SumOfNumbers(m, n);

Console.WriteLine();
Console.Write($"M = {m}; N = {n}. -> "); 
PrintFromMToN(m, n);
Console.Write($" Сумма чисел = {sumNumber}");