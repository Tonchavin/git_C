using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);
int result = ProgNumber(number);
WriteLine($"Произведение числе от 1 до {number} = {result}");

int ProgNumber(int A)
{
    int i = 1;
    while(A > 0)
    {
        i *= A;
        A--;
    }
    return i;
}
