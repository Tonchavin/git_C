using static System.Console;
Clear();

WriteLine("Введите сторону треугольника: ");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int c = int.Parse(ReadLine()!);

WriteLine(Tringl(a, b, c) ? $"Треугольник со сторанами {a},{b},{c} существует" : $"Треугольник со сторанами {a},{b},{c} не существует");

bool Tringl(int inA, int inB, int inC)
{
    if (a + b > c && a + c > b && b + c > a) return true;
    return false;
}