using static System.Console;

WriteLine("Введите два числа: ");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
if (b * b == a)
{
    WriteLine($"число {a} является квадратом числа {b}");
}
else
{
    WriteLine($"число {a} неявляется квадратом числа {b}");
}
