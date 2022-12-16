using static System.Console;

Write("Введите число: ");
int a = int.Parse(ReadLine()!);
int i = -a;
while (i <= a)
{
    Write($"{i} ");
    i = i + 1;
}
