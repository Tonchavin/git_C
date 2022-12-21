using static System.Console;
Clear();

int number = new Random().Next(10, 100);
WriteLine(number);
WriteLine(number/10>number%10?number/10:number%10); // испол. тернарного оператора
//if (a1 > a2)                                      // обычный код
//{
//    WriteLine(a1);
//}
//else
//{
//    WriteLine(a2);
//}
