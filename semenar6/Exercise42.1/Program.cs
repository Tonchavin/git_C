using static System.Console;
Clear();

Write("Введите 6-ти значный номер билета через пробел: ");
string[] ticket = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int a = Int32.Parse(ticket[0]);
int b = Int32.Parse(ticket[1]);
int c = Int32.Parse(ticket[2]);
int d = Int32.Parse(ticket[3]);
int e = Int32.Parse(ticket[4]);
int f = Int32.Parse(ticket[5]);

Write(a+b+c == d+e+f? $"Счастливый" : $"Не счастливый");
