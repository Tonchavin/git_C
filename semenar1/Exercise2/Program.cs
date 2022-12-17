using static System.Console;

Write("Введите два числа: ");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
if (a > b)
{
    WriteLine($"{a} наибольшее число, а {b} наименьшее");
}
else
{
    WriteLine($"{b} наибольшее число, а {a} наименьшее");
}
