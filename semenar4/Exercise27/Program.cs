using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);

SumNumber(number);
PrintNumber(SumNumber(number));

int SumNumber(int num)
{
    while (num > 9 && num <= 9999)
    {
        if (num <= 99)
        {
            num = number / 10;
            num += number % 10;
            break;
        }
        if (num > 99 && num <= 999 )
        {
            num = number % 10;
            num += number / 100;
            num += (number / 10) % 10;
            break;
        }
        if (num > 999 && num <= 9999 )
        {
            num = number % 10;
            num += number / 1000;
            num += (number / 10) % 10;
            num += (number / 100) % 10;
            break;
        }
    }
    return num;
}
void PrintNumber(int num)
    {
        Write($"Сумма цифр в числе {number} равна: {num} ");
        WriteLine(num > 9999?$"число большое, введите меньшое":"");
    }
