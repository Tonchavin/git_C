using static System.Console;
Clear();

Write("Введите число: ");
int a = int.Parse(ReadLine()!);
for (int i = 1; i <= a; i++)
{
    if (i % 2 == 0)
    Write($"{i} ");
}
