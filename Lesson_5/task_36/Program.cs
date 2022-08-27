// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();

void arrayOfRandomNumbers(int[] values)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = new Random().Next(-1000, 1000);
    }
}

void printSumOfOddPositions(int[] number)
{
    int sumNumber = 0;

    Console.Write("[");

    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{number[i]}, ");
    }

    Console.Write("\b");
    Console.Write("\b");
    Console.Write("] - > ");

    for (int j = 1; j < number.Length; j += 2)
    {
        sumNumber += number[j];
    }
    
    Console.Write(sumNumber);
    Console.WriteLine();
}

int[] array = new int[4];

arrayOfRandomNumbers(array);
printSumOfOddPositions(array);