using static System.Console;
Clear();

WriteLine("Ввидите количество деталей: ");
int count = int.Parse(ReadLine()!);
int num1 = 0;
int num2 = 0;
int num3 = 0;
if (count%10 == 0)
{
    num3 = count / 2;
    num1 = num3 / 2;
    num2 = num3 / 2;
    WriteLine($"Старший слесарь:{num3}, а младшие по: {num1} и {num2}");
}
