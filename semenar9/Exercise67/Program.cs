using static System.Console;
Clear();

Write(SumNumbers(255));

int SumNumbers(int num)
{
    if (num == 0) return 0;
    else
    {
        return SumNumbers(num / 10) + num % 10;
    }
}