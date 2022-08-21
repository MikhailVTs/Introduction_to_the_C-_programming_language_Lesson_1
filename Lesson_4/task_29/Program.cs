// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

Console.Clear();

void DArray (int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{i +=1}. Массив под индексом {i -=1}: ");
        number[i] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine();
}


void PArray (int[] numbers)
{
    Console.Write("[");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"{numbers[i]}, ");
    }
    Console.Write("\b");
    Console.Write("\b");
    Console.Write("]"); 
}

Console.WriteLine("Введите массив из 8 чисел: ");

int[] array = new int[8];

DArray(array);
PArray(array);