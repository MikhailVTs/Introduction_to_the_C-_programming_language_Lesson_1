// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int [,] NewArray(int[,] newarray)
{
    for(int i = 0; i < newarray.GetLength(0); i++)
    {
        for(int j = 0; j < newarray.GetLength(1); j++)
        {
            newarray[i, j] = new Random().Next(1, 10);
        }
    }
    return newarray;
}

int [,] NewArray1(int[,] newarray1)
{
    for(int i = 0; i < newarray1.GetLength(0); i++)
    {
        for(int j = 0; j < newarray1.GetLength(1); j++)
        {
            newarray1[i, j] = new Random().Next(1, 10);
        }
    }
    return newarray1;
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

int[,] MultiplicationArray(int[,] array, int[,] array1)
{

    int[,] array2 = new int [array.Length, array1.Length];
    
    for (int i = 0; i < array1.GetLength(1); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            array2[i, j] = 0;
            for (int k = 0; k < array1.GetLength(0); k++)
            {
                array2[i,j] += array[i,k] * array1[k,j]; 
                
            }
        }
    }
    Console.WriteLine();
    return array2;
}

int[,] array = new int[4,5];
int[,] array1 = new int[4,5];
Console.WriteLine("Двумерный массив:");
Console.WriteLine();
NewArray(array);
NewArray1(array1);
PrintArray(array);
Console.WriteLine();
PrintArray(array1);
Console.WriteLine();
MultiplicationArray(array, array1);
