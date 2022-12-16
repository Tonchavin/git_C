using static System.Console;

Write("Введите число: ");

int a = int.Parse(ReadLine()!);  //int.Parse() работает в себе со строками
                                //Convert.ToInt32() работает в себе с любыми данными
WriteLine($"Квадрат числа {a} равен {a * a}");
