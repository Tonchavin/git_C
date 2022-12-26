using static System.Console;
Clear();

WriteLine("Ввидите количество деталей: ");
int count = int.Parse(ReadLine()!);
int num1 = 0;                               // старший токарь
int num2 = 0;                               // младший токарь                           

if (count > 5 && count % 6 == 0)
{ 
    num2 = count / 6;
    num1 = (num2 + num2) * 2; 
    WriteLine($"Старший токарь:{num1}, а младшие токари по: {num2} и {num2}");
}
else 
{
    WriteLine("Токарь ошибся");
}
