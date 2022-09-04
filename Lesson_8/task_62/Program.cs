// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();



void NewArray(int[,] array)
{
    int count = 1;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = count++;
        }

    }
}

void PrintArray(int[,] values)
{
    for (int i = 0; i < values.GetLength(0); i++)
    {
        for (int j = 0; j < values.GetLength(1); j++)
        {

            Console.Write($"{values[i, j]} ");
        }
        Console.WriteLine();

    }
}

void FillArray(int row, int colum)
{
    int[,] array = new int[5, 5];
    if (array[row, colum] == 0)
    {
        FillArray(row, colum + 1);
        FillArray(row + 1, colum);
        FillArray(row, colum - 1);
        FillArray(row - 1, colum);
    }
}



int[,] array = new int[5, 5];

Console.WriteLine();

NewArray(array);
PrintArray(array);
FillArray(3,3);
PrintArray(array);