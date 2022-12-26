using static System.Console;
Clear();

WriteLine("Введите кардинаты двух точек: a и b");
WriteLine("Введите кардинаты точки а: ");
int ax = int.Parse(ReadLine()!);
int ay = int.Parse(ReadLine()!);
WriteLine("Введите кардинаты точки b: ");
int bx = int.Parse(ReadLine()!);
int by = int.Parse(ReadLine()!);
double result;

// WriteLine($"Расстояние между точками: {result = ((bx - ax) ^ 2 + (by - ay) ^ 2) ^ (1 / 2)}"); // S = ((x2 - x1)^2 + (y2 - y1)^2)^(1/2);
WriteLine($"Расстояние между точками: {result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2))}");// WriteLine($"{result:f2}") - result:f2 округление вывода до 2-ух наков.
