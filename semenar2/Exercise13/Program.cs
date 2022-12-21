using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
WriteLine(a < 100? "третьей цифры нет" : (a / 100) % 10);
