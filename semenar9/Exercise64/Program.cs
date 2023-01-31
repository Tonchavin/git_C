using static System.Console;
Clear();

Write("Введите число: ");
int result =int.Parse(ReadLine()!);
Write(GetNumbers(result));

string GetNumbers(int num)
{
    if(num == 1) return num.ToString();
    else return $"{num},{GetNumbers(num-1)}";
} 