// РАЗВОРОТ

// Дано натуральное число N и последовательность из N элементов. 
// Требуется вывести эту последовательность в обратном порядке.

// Входные данные
// В первой строке натуральное число N (N ≤ 1000). 
// Во второй строке через пробел идут N целых чисел, по модулю не превосходящих 1000 - элементы 
// последовательности.

// Выходные данные
// Выведите заданную последовательность в обратном порядке.

// Пример:
// Входные данные:
// 3
// 1 2 3

// Выходные данные:
// 3 2 1

Console.Clear();

void arrayNum(int[] values)
{
    int k = 1;
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = k + i;
    }
}

void printInputAndOutput(int[] number)
{
    Console.WriteLine();
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{number[i]} ");
    }
    Console.Write("\b");
    Console.WriteLine();
    Console.WriteLine();

    for (int j = number.Length - 1; j >= 0; j--)
    {
        Console.Write($"{number[j]} ");
    }
    Console.Write("\b");
    Console.WriteLine();
}

Console.Write("Введите натуральное число N (N <= 1000): ");

int num = int.Parse(Console.ReadLine()!);

int[] array = new int[num];

arrayNum(array);
printInputAndOutput(array);