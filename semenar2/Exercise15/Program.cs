using static System.Console;
Clear();

WriteLine("Введите номер дня недели: ");
int a = int.Parse(ReadLine()!);
WriteLine(a == 6 || a == 7? "Выходной!": "Не является выходным");
