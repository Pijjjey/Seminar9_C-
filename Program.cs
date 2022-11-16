//Задача 64

/*Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(PrintNumbers(N,1));

string PrintNumbers(int start, int end)
{
    if(start==end)
    {
        return start.ToString();
    }
    else
    {
        return start + " " + PrintNumbers(start-1, end);
    }
}*/

//Задача 66
/*Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine(FindSum(M, N));

int FindSum(int start, int end)
{
    int sum = 0;
    if(start==end) return sum + end;
    return sum + start + FindSum(start + 1, end);
}*/

//Задача 68

Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(A(m,n));

int A(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return A(m - 1, 1);
    else
      return A(m - 1, A(m, n - 1));
}


