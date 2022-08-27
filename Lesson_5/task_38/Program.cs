// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3, 7, 22, 2, 78] -> 76

Console.Clear();

void arrayOfTenNumbers(int[] values)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = new Random().Next(1001);
    }
}

void printValues(int[] number)
{
    int maxNumber = 0;
    int minNumber = number[0];

    Console.Write("[");
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{number[i]}, ");

        if (number[i] < minNumber)
        {
            minNumber = number[i];
        }

        if (number[i] > maxNumber)
        {
            maxNumber = number[i];
        }
    }

    int difMaxAndMinArrayElements = maxNumber - minNumber;

    Console.Write("\b");
    Console.Write("\b");
    Console.Write("] - > ");
    Console.Write(difMaxAndMinArrayElements);
    Console.WriteLine();
}

int[] array = new int[10];

arrayOfTenNumbers(array);
printValues(array);