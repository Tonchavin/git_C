//Первый вариант решения:
using static System.Console;

//Write("Введите число: ");
//int a = int.Parse(ReadLine()!);
//while(a > 100)
//{
//    a = a % 10;
//    Write(a);
//}

//Второй вариант решения:

Write("Введите число: ");
int n = int.Parse(ReadLine()!);
if (n >= 100 && n <= 999)
{
  WriteLine(n % 10);
}
else
{
    WriteLine("Введено не трехзначное число");
}
