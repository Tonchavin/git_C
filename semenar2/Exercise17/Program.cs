using static System.Console;
Clear();

WriteLine("Введите два числа: ");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int max = (a + b) - 1;
WriteLine($"Банок всего: {max}");
