using static System.Console;
Clear();

Write("Введите число: ");
int a = int.Parse(ReadLine()!);
if ((a % 2) == 0)
{
    WriteLine($"число {a} является четным");
}
else
{
    WriteLine($"число {a} является нечетным");
}
