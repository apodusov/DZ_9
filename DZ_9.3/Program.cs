// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = EnterInt("Введите целое положительное число m: ");
int n = EnterInt("Введите целое положительное число n: ");

Console.WriteLine(GetAckermannsFunction(m, n));

int EnterInt(string prompt)
{
      Console.Write(prompt);
      return int.Parse(Console.ReadLine()!);
}

int GetAckermannsFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) 
        return GetAckermannsFunction(m - 1, 1);
    return (GetAckermannsFunction(m - 1, GetAckermannsFunction(m, n - 1)));
}