// Напишите программуб которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int SumNumbers (int numbers, int sumnumber)
{
  while(numbers != 0)
  {
    int number = numbers % 10;
    numbers /= 10;
    sumnumber += number; 
  }
  return sumnumber;
}

Console.Write("Введите число: ");
int numbers = int.Parse(Console.ReadLine()!);
int sumnumber = 0;

int SumN = SumNumbers (numbers, sumnumber);
Console.WriteLine($"{numbers} -> {SumN}");