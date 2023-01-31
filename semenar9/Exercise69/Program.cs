using static System.Console;
Clear();

//1 Способ
// Write(PowNumbers(2, 3));

// int PowNumbers(int num1, int num2)
// {
//     if (num2 == 0) return 1;
//     else
//     {
//         return PowNumbers(num1, num2 - 1) * num1;
//     }
// }

//2-ой Способ

Write("Введите число и степень через пробел: ");
string[] str_arg = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

WriteLine(Numbers(int.Parse(str_arg[0]), (int.Parse(str_arg[1]))));

int Numbers(int a, int b)
{
    if (b == 1) return a;
    else return Numbers(a, b - 1) * a;
}