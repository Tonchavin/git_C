using static System.Console;
Clear();

WriteLine("Ввидите число: ");
int number = int.Parse(ReadLine()!);
int result = SumNumber(number);
WriteLine($"Сумма чисел,которые делятся на N без остатка: {result}");

int SumNumber(int a)
{
    int i = 0;
    int j = a;

    while(a > 0)
    {
        if(j % a == 0)
        {
            i += a;           
        }
        a--;
    }
    return i;
}
