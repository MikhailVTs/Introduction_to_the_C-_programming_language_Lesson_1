// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void PrintIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 != k2)
    {
        double coordinateX = (((b1 + (b2*(-1))) * (-1)) / (k1 + (k2 * (-1))));
        double coordinateY = k2 * coordinateX + b2;
        string coordinateXY = $"{coordinateX}; {coordinateY}";
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({coordinateXY})");
    }
    if (k1 == k2 )
    {
        string coordinateXYLinesAreParallel = $"Координаты равны (k1 = {k1} и k2 = {k2}) - Линии паралельны, точка пересечения отсутствует."; 
        Console.WriteLine(coordinateXYLinesAreParallel);
    }
}

Console.WriteLine("Введите координатые точки");

Console.Write("Введите координаты b1: ");
double b1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты k1: ");
double k1 = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты b2: ");
double b2 = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты k2: ");
double k2 = double.Parse(Console.ReadLine()!);

Console.WriteLine();

PrintIntersectionPoint(b1, k1, b2, k2);