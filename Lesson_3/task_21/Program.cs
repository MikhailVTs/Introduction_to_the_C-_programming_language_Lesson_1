// Напишите программу, которая принимает на вход координаты 
// двух точек и находит расстояние между ними в 3D пространстве.

// A(3,6,8); B(2,1,-7), -> 15.84
// A(7,-5,0); B(1,-1,9), -> 11.53

Console.Clear();


double Distance (double xa, double ya, double za, double xb, double yb, double zb) 
{
    double rastoyanie = Math.Sqrt(Math.Pow(xa - xb,2) + Math.Pow(ya - yb,2) + Math.Pow(za - zb,2));
    return rastoyanie;
}


Console.WriteLine("Введите координаты точки А");

Console.Write("Введите координаты xa: ");
double xa = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты ya: ");
double ya = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты za: ");
double za = double.Parse(Console.ReadLine()!);

Console.WriteLine();

Console.WriteLine("Введите координаты точки B");

Console.Write("Введите координаты xb: ");
double xb = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты yb: ");
double yb = double.Parse(Console.ReadLine()!);

Console.Write("Введите координаты zb: ");
double zb = double.Parse(Console.ReadLine()!);

double asd = Distance (xa, ya, za, xb, yb, zb);

Console.WriteLine();
Console.WriteLine($"A({xa},{ya},{za}); B({xb},{yb},{zb}), -> {asd:f2}");