// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine()!);

int number1 = number / 10000 % 10;
int number2 = number / 1000 % 10;
int number4 = number / 10 % 10;
int number5 = number % 10;

if (number1 == number5 && number2 == number4) 
{
    Console.WriteLine($"{number} -> да");
}
else
{
    Console.WriteLine($"{number} -> нет");
}