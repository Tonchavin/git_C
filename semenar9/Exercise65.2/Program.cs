using static System.Console;
Clear();

Write(PrintNumbers(8, 2));

string PrintNumbers(int min, int max)
{
    if (min > max)
    {
        int temp = 0;
        temp = min;
        min = max;
        max = temp;
    }
    return (max == min) ? max.ToString() : $"{PrintNumbers(min, max - 1)},{max}";
}