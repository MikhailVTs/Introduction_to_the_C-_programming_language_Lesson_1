// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();

void NewArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next();
                
            }
            
        }

    }
}

void PrintArray (int[,,] values)
{
    for (int i = 0; i < values.GetLength(0); i++)
    {
        for (int j = 0; j < values.GetLength(1); j++)
        {
            for (int k = 0; k < values.GetLength(2); k++)
            {
                Console.Write(values[i, j, k]);                
            }
            Console.WriteLine();



        }
        Console.WriteLine();

    }
}

int m = 2;
int n = 2;
int l = 2;

int[,,] array = new int[m, n, l];

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Трёхмерный массив размером {m} x {n} х {l}, заполненный случайными числами.");
Console.WriteLine();

NewArray(array);
PrintArray(array);