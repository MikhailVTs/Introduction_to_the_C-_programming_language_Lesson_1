// Задача 15: Напишите программу, которая принимает на вход цифру, 
//            обозначающую день недели, и проверяет, является ли этот 
//            день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите день недели: ");
int day = int.Parse(Console.ReadLine()!);

string yes = "да";
string no = "нет";
string error_day = "Ошибка: Всего 7 дней в недели, такого дня недели не существует. Проверьте правильность ввода дня недели.";

switch (day) 
{
    case 1:
    Console.ForegroundColor = ConsoleColor.DarkCyan;    // Меняем цвет шрифта на темно-голубой
    Console.WriteLine($"{day} -> {no}");
    break;

    case 2:
    Console.ForegroundColor = ConsoleColor.DarkCyan;    // Меняем цвет шрифта на темно-голубой
    Console.WriteLine($"{day} -> {no}");
    break;

    case 3:
    Console.ForegroundColor = ConsoleColor.DarkCyan;    // Меняем цвет шрифта на темно-голубой
    Console.WriteLine($"{day} -> {no}");
    break;
    
    case 4:
    Console.ForegroundColor = ConsoleColor.DarkCyan;    // Меняем цвет шрифта на темно-голубой
    Console.WriteLine($"{day} -> {no}");
    break;

    case 5:
    Console.ForegroundColor = ConsoleColor.DarkCyan;    // Меняем цвет шрифта на темно-голубой
    Console.WriteLine($"{day} -> {no}");
    break;

    case 6:
    Console.ForegroundColor = ConsoleColor.DarkGreen;    // Меняем цвет шрифта на темно-зеленый
    Console.WriteLine($"{day} -> {yes}");
    break;

    case 7:
    Console.ForegroundColor = ConsoleColor.DarkGreen;    // Меняем цвет шрифта на темно-зеленый
    Console.WriteLine($"{day} -> {yes}");
    break;

    default:
    Console.ForegroundColor = ConsoleColor.Red;    // Меняем цвет шрифта на красный
    Console.WriteLine($"{error_day}");
    break;
}