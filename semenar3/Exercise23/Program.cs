using static System.Console;
Clear();

Write("Введите число для вывода кубов от 1 до ");
int.TryParse(ReadLine(), out int n);
int i = 1;
while(i <= n)
{
    WriteLine($"квадрат числа {i} = {Math.Pow(i, 3)}");
    i++;
}
