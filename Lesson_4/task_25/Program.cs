// Напишите цикл, который принимает на вход два 
// числа (А и В) и возводит число А в натуральную степень В.

// 3, 5 -> 243
// 2, 4 -> 16

int VozvedenieVStepen (int a, int b)
{
    for (int i = 1; i < b+1; i++)
    {
        a *= a;
        Console.WriteLine(a);
    }

    return a;
}

Console.WriteLine("Введите знчение А: ");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

int stepen = VozvedenieVStepen(a, b);

Console.WriteLine(stepen);