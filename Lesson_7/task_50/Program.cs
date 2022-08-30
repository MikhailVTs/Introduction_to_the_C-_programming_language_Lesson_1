// Задача 50. Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();

void NewArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = new Random().Next(1, 51);
        }
    }
    Console.WriteLine();
}

void PrintNewArray(int[,] printArray)
{
    for (int i = 0; i < printArray.GetLength(0); i++)
    {
        for (int j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($"{printArray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindAndPrint(int[,] values)
{
    int a = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    int count = 0;
    for (int i = 0; i < values.GetLength(0); i++)
    {
        for (int j = 0; j < values.GetLength(1); j++)
        {
            if (values[i, j] == a)
            {
                Console.WriteLine($"{a} -> [{i}, {j}]");
                count++;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine($"{a} -> такого числа в массиве нет");
    }
}

int[,] array = new int[4, 4];

Console.WriteLine("Двумерный массив");

NewArray(array);
PrintNewArray(array);

Console.Write("Введите значение для возвращения значения этого элемента: ");

FindAndPrint(array);