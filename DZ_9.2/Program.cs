// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = EnterInt("Введите целое число M: ");
int N = EnterInt("Введите целое число N: ");

int numMin = Min(M, N);
int numMax = Max(M, N);
string strNums = GetNaturalRowBetweenMN(numMin, numMax);
string[] elemNums = strNums.Split(' ');

int[] nums = Array.ConvertAll(elemNums, int.Parse);
Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} = {GetNumsSum(nums)}");


int EnterInt(string prompt)
{
      Console.Write(prompt);
      return int.Parse(Console.ReadLine()!);
}


int Min(int a, int b)
{
      return a < b ? a : b;
}

int Max(int a, int b)
{
      return a > b ? a : b;
}


string GetNaturalRowBetweenMN (int numMin, int numMax)
{
      if (numMax == numMin)
            return numMin.ToString();
      
      return numMin + " " + GetNaturalRowBetweenMN(numMin + 1, numMax); 
}

int GetNumsSum(int[] nums)
{
      int sum = 0;
      for (int i = 0; i < nums.Length; i++)
      {
            sum += nums[i];
      }
      return sum;
}