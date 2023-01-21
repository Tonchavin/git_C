using static System.Console;
Clear();

Write("Введите число: ");
int A =int.Parse(ReadLine()!);

WriteLine($"В двоичной системе: {A} = {DecimalToBinary(A)}");

string DecimalToBinary(int inA)
{
    if(inA == 0)return "0";
    int ostatok;
    string result = string.Empty;
    while (inA > 0)
    {
        ostatok = inA%2;
        inA/=2;
        result=ostatok.ToString()+result;
    }
    return result;
}