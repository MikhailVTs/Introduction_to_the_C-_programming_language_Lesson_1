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

if (day >= 1 && day <= 5)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;    // Меняем цвет шрифта на темно-голубой
    Console.WriteLine($"{day} -> {no}");    
}

else 
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;    // Меняем цвет шрифта на темно-зеленый
    Console.WriteLine($"{day} -> {yes}");
}