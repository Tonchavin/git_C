using static System.Console;
Clear();

WriteLine("Введите число: ");
int A = int.Parse(ReadLine()!);
WriteLine("Введите степень числа: ");
int B = int.Parse(ReadLine()!);

ABstepen(A, B);
PrintNumber(ABstepen(A, B));

int ABstepen(int A1, int B1)
{
    int result = A1;
    for (int i = 1; i < B1; i++)
    {
        result *= A1; 
    }
    return result;
}
void PrintNumber(int result)
{
    WriteLine($"Число {A} в степени {B}: {ABstepen(A, B)}");
}
