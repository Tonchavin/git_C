using static System.Console;
Clear();

WriteLine("Введите трех значное число: ");
int a = int.Parse(ReadLine()!);
WriteLine((a / 10) % 10);
