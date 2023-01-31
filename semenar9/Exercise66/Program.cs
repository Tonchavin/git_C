using static System.Console;
Clear();

Write("Введите минимальное и максимальное число через пробел: ");
string[] str_arg = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(Numbers(int.Parse(str_arg[0]), (int.Parse(str_arg[1]))));

int Numbers(int a, int b)
{
    if (b == a) return a;
    else return Numbers(a, b-1) + b;
}