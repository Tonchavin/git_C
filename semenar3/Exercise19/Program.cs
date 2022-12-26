using static System.Console;
Clear();

WriteLine("Введите пятизначное число: ");
int.TryParse(ReadLine(),out int a);

int number1 = a % 10;
int number2 = (a / 10) % 10;
int number4 = (a / 1000) % 10;
int number5 = (a / 10000) % 10;
if (a > 9999 && a < 100000)
{
    WriteLine(number1 == number5 && number2 ==number4?$"Число является палиндромом": "Число неявляется палиндромом");
}
else
{
    WriteLine("Введено не пятизначное число");
}
