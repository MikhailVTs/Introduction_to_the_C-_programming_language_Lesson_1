// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223 -> 3

Console.Clear();

void NumberOfNumbersGreaterThanZero(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(-1000, 1000);
    }
}

void PrintNumberOfNumbersGreaterThanZero(int[] values)
{
    Console.WriteLine();
    int count = 0;
    for (int j = 0; j < values.Length; j++)
    {
        Console.Write($"{values[j]}, ");
        if (values[j] > 0)
        {
            count++;
        }
    }
    Console.Write("\b");
    Console.Write("\b");
    Console.Write($" -> {count}");
}

Console.Write("Введите количество чисел: ");
int m = int.Parse(Console.ReadLine()!);

int[] array = new int[m];

NumberOfNumbersGreaterThanZero(array);
PrintNumberOfNumbersGreaterThanZero(array);