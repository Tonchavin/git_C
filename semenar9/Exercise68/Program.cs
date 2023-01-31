using static System.Console;
Clear();

Write("Введите два неотрицательных числа через пробел: ");
string[] str_arg = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(Numbers(int.Parse(str_arg[0]), (int.Parse(str_arg[1]))));

int Numbers(int n, int m)
{
    if (n == 0)
        return m + 1;
    else
      if ((n != 0) && (m == 0))
        return Numbers(n - 1, 1);
    else
        return Numbers(n - 1, Numbers(n, m - 1));
}