using static System.Console;
Clear();

WriteLine("Введите два числа: ");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
WriteLine(a * a == b? "первое число является квадратом второго": 
          b * b == a?"второе число является квадратом первого": 
          "не является квадратом");
