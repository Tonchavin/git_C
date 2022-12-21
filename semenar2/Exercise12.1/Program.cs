using static System.Console;
Clear();

WriteLine("Введите два числа: ");
int number1 = int.Parse(ReadLine()!);
int number2 = int.Parse(ReadLine()!);
WriteLine(number1 == number2? "=" :number1 > number2? ">" : "<");
