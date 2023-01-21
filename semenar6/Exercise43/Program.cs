// y = k1 * x + b1, y = k2 * x + b2
// k1 * x + b1 = k2 * x + b2
// (k1 - k2) * x = b2 - b1
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1              
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
// x = (4 - 2) / (5 - 9) == -0,5
// y = 5 * (-0,5) + 2 == -0,5

// WriteLine("введите значение b1");
// double b1 = Convert.ToInt32(ReadLine()!);
// WriteLine("введите число k1");
// double k1 = Convert.ToInt32(ReadLine()!);
// WriteLine("введите значение b2");
// double b2 = Convert.ToInt32(ReadLine()!);
// WriteLine("введите число k2");
// double k2 = Convert.ToInt32(ReadLine()!);

// double x = (-b2 + b1)/(-k1 + k2);
// double y = k2 * x + b2;

// WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
using static System.Console;
Clear();

Write("Введите кардинаты точек А и В через пробел: ");
string[] AB = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double b1 = Int32.Parse(AB[0]);
double k1 = Int32.Parse(AB[1]);
double b2 = Int32.Parse(AB[2]);
double k2 = Int32.Parse(AB[3]);
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

WriteLine($"Две прямые пересекутся в координатах: ({x}; {y})");