// Напишите цикл, который принимает на вход два 
// числа (А и В) и возводит число А в натуральную степень В.

// 3, 5 -> 243
// 2, 4 -> 16

Console.Clear();

int VozvedenieVStepen (int a, int b, int m)
{
    for (int i = 1; i < b+1; i++)
    {
        m *= a;
    }

    return m;
}

Console.WriteLine("Введите знчение А: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите знчение B: ");
int b = int.Parse(Console.ReadLine()!);

int m = 1;

int stepen = VozvedenieVStepen(a, b, m);
Console.WriteLine();
Console.WriteLine($"{a}, {b} -> {stepen}");