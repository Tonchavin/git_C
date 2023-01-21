using static System.Console;
Clear();

Write("Введите числа через пробел: ");
string[] number = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(CountNumber(number));

int CountNumber(string[] num)
{
    int count = 0;
    foreach (string i in num)
    {
        if (Int32.Parse(i) > 0)
        {
            count += 1;
        }
    }
    return count;
}
