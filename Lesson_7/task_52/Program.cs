/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Clear();


void NewArray(int[,] newarray)
{
	for(int i = 0; i < newarray.GetLength(0); i++)
	{
		for (int j = 0; j < newarray.GetLength(1); j++)
		{
			newarray[i,j]= new Random(). Next (1,10);
		}
	}
}

void PrintArray(int[,] printarray)
{
	for(int i = 0; i < printarray.GetLength(0); i++)
	{
		for (int j = 0; j < printarray.GetLength(1); j++)
		{
			Console.Write($"{printarray[i,j]} ");
		}
		Console.WriteLine();
	}
    Console.WriteLine();
}

Console.WriteLine();

void PrintMeanArray(int[,] meanArray)
{
    double average = 0;
    int a = 0; 
    Console.Write("Среднее арифметическое каждого столбца: ");
    while(a != meanArray.GetLength(1))
    {
        for (int i = 0; i < meanArray.GetLength(0); i++)
        {
            average += meanArray[i, a];
        }
        a++;
        average = average/meanArray.GetLength(0);
        Console.Write($"{average:f1}; ");
        average *= 0;
    }

    Console.Write("\b");
    Console.Write("\b");
    Console.Write(".");
    Console.WriteLine();
} 

Console.WriteLine("Введите параметры двумерного массива:");
Console.WriteLine();
Console.Write("1. Введите количество строк двумерного массива: ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("2. Введите количество столбцов двумерного массива: ");
int column = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"Двумерный массив {row} х {column}");
Console.WriteLine();

int[,] array = new int[row,column];

NewArray(array);
PrintArray(array);
PrintMeanArray(array);