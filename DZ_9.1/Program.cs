// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите целое число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetNaturalRow(N));

string GetNaturalRow (int N)
{
      if (N == 1)
            return "1";
      return N + ", " + GetNaturalRow(N - 1);
}
