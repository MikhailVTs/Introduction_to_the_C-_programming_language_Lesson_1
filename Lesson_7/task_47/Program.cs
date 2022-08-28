// Задача 47. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.Clear();

void NewArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble();
        }

    }
}

void PrintArray (double[,] values)
{
    for (int i = 0; i < values.GetLength(0); i++)
    {
        for (int j = 0; j < values.GetLength(1); j++)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write($"{values[i, j]:f2} ");
        }
        Console.WriteLine();

    }
}

int m = 3;
int n = 4;

double[,] array = new double[m, n];

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Двумерный массив размером {m} x {n}, заполненный случайными вещественными числами.");
Console.WriteLine();

NewArray(array);
PrintArray(array);