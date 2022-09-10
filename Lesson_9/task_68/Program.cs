// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.Clear();

int Ackerman(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return Ackerman(m - 1, 1);
    else
      return Ackerman(m - 1, Ackerman(m, n - 1));
}

Console.WriteLine("Введите числа M и N, для нахождения функции Аккермана.");
Console.WriteLine();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int ackerman = Ackerman(m, n);

Console.WriteLine();
Console.Write($"m = {m}, n = {n} -> A(m,n) = {ackerman}");
Console.WriteLine();