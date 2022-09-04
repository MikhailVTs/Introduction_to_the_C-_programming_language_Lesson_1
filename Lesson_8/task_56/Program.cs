// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка

Console.Clear();

void NewArray(int[,] newarray)
{
    for(int i = 0; i < newarray.GetLength(0); i++)
    {
        for(int j = 0; j < newarray.GetLength(1); j++)
        {
            newarray[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] printArray)
{
    for(int i = 0; i < printArray.GetLength(0); i++)
    {
        for(int j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($"{printArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindArray(int[,] findArray)
{
    int sumA = 0;
    int minSum = 100;
    int count = 0;
    int rowArray = 0;
    for (int i = 0; i < findArray.GetLength(0); i++)
    {
        for (int j = 0; j < findArray.GetLength(1); j++)
        {
            sumA += findArray[i, j];
        }
        count ++;
        if (sumA < minSum)
        {
            minSum = sumA;
            rowArray = count;
        } 
        sumA *= 0;

    }
    Console.WriteLine();
    Console.WriteLine($"строки с наименьшей суммой элементов: {rowArray} строка");
}

int[,] array = new int[4,5];
Console.WriteLine("Двумерный массив:");
Console.WriteLine();
NewArray(array);
PrintArray(array);
FindArray(array);
