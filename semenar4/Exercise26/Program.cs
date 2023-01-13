using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);
int result = CountNumber(number);
WriteLine($"Количество цифр в числе: {result}");

int CountNumber(int A)
{
    int i = 0;
    while(A > 0)
    {
        i++;
        A/= 10;
    }
    return i;
}
