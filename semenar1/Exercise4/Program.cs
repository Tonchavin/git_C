using static System.Console;
Clear();

Write("Введите три числа: ");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int c = int.Parse(ReadLine()!);

if (a > b & a > c)
{
    WriteLine($"{a} наибольшее число"); 
}
else if (b > c)
{
    WriteLine($"{b} наибольшее число");
}
else
{
    WriteLine($"{c} наибольшее число");
}