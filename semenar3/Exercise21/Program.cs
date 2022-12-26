using static System.Console;
Clear();

WriteLine("Введите кардинаты двух точек: a и b");
WriteLine("Введите кардинаты точки а: x y z ");
int ax = int.Parse(ReadLine()!);
int ay = int.Parse(ReadLine()!);
int az = int.Parse(ReadLine()!);
WriteLine("Введите кардинаты точки b: x y z ");
int bx = int.Parse(ReadLine()!);
int by = int.Parse(ReadLine()!);
int bz = int.Parse(ReadLine()!);

                                                                                                    // Расстояние между точками: S = ((x2 - x1)^2 + (y2 - y1)^2)^(1/2);
double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
WriteLine($"{result:f2}");                                                                          // WriteLine($"{result:f2}") - result:f2 округление вывода до 2-ух наков.
