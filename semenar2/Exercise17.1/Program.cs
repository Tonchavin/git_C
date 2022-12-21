using static System.Console;
Clear();

WriteLine("Введите количество цветов: ");
int n = int.Parse(ReadLine()!);
WriteLine(n > 2? $"минимальное количество бисинок вытащиных одновременно {n + 1}" : "2 бусинки");
