using static System.Console;
Clear();

WriteLine("Введите число: ");
int a = int.Parse(ReadLine()!);
int b = 7;
int c = 23;
WriteLine(a % b == 0 && a % c == 0? "кратно 7 и 23 одновременно": "не кратно 7 и 23 одновременно");
