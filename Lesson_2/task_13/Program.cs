// Задача 13: Напишите программу, которая выводит 
//            третью цифру заданного числа или сообщает, 
//            что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Clear();

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);


if (number > 99) 
{
    int secondDigitOfThisNumber = number / 100 % 10;
    Console.WriteLine($"{number} -> {secondDigitOfThisNumber}");
}

if (number > 0 && number < 100) 
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}