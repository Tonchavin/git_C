using static System.Console;
Clear();

Write(PrintNumbers(2, 8));

string PrintNumbers(int min, int max)
{
    return (max == min) ? max.ToString() : $"{PrintNumbers(min, max - 1)},{max}";
}