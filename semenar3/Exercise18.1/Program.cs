using static System.Console;
Clear();

WriteLine("Введите x и y: ");
int x = int.Parse(ReadLine()!);
int y = int.Parse(ReadLine()!);

if (x == 0 || y == 0){WriteLine("ERROR"); return;}
if (x > 0 && y > 0){WriteLine("Первая четверть"); return;} 
if (x < 0 && y > 0){WriteLine("Вторая четверть"); return;}
if (x < 0 && y < 0){WriteLine("Третья четверть"); return;}
if (x > 0 && y < 0){WriteLine("Четвертая четверть"); return;}
