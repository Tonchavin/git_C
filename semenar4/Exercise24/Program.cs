using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(ReadLine()!);
int sum = GetSum(number);
WriteLine($"Сумма от 1 до {number} = {sum}");




int GetSum(int A)
{
    int result = 0;
    while(A > 0)
    {
        result+= A;
        A--;
    }
    return result;
}