// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();

void arrayOfThreeNumbers(int[] values)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = new Random().Next(100, 1000);
    }
}

void printValues(int[] positiveNumber)
{
    int numberOfEvenNumbers = 0;

    Console.Write("[");
    for (int i = 0; i < positiveNumber.Length; i++)
    {

        if (positiveNumber[i] % 2 == 0)
        {
            numberOfEvenNumbers++;
        }
        Console.Write($"{positiveNumber[i]}, ");
    }
    Console.Write("\b");
    Console.Write("\b");
    Console.Write("] - > ");
    Console.Write(numberOfEvenNumbers);
    Console.WriteLine();
}

int[] array = new int[4];

arrayOfThreeNumbers(array);
printValues(array);