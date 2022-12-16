using static System.Console;

Write("Ввидите номер дня недели от 1 до 7: ");
int a = int.Parse(ReadLine()!);
string b1 = "Понедельник";
string b2 = "Вторник";
string b3 = "Среда";
string b4 = "Четверг";
string b5 = "Пятница";
string b6 = "Суббота";
string b7 = "Воскресение";
if (a == 1){WriteLine(b1);}
if (a == 2){WriteLine(b2);}
if (a == 3){WriteLine(b3);}
if (a == 4){WriteLine(b4);}
if (a == 5){WriteLine(b5);}
if (a == 6){WriteLine(b6);}
if (a == 7){WriteLine(b7);}
