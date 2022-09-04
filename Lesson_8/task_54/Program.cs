//Задача 54: Задайте двумерный массив.
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

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

void SortingArray(int[,] sortingArray)
{
    int temp;
    int max;
    for (int i = 0; i < sortingArray.GetLength(0); i++)
    {
        for (int j = 0; j < sortingArray.GetLength(1)-1; j++)
        {
            max = j;

            for (int k = j + 1; k < sortingArray.GetLength(1); k++)
            {
                if (sortingArray[i, k] > sortingArray[i, max])
                {
                    max = k;              
                }           
            }
            if (max != j)
            {
                temp = sortingArray[i, j];
                sortingArray[i, j] = sortingArray[i, max];
                sortingArray[i, max] = temp;
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Упорядочные по убыванию элементы каждой строки двумерного массива:");
    Console.WriteLine();
}


int[,] array = new int[4,4];
Console.WriteLine("Двумерный массив:");
Console.WriteLine();
NewArray(array);
PrintArray(array);
SortingArray(array);
PrintArray(array);