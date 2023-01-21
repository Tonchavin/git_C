using static System.Console;
Clear();

Write("Введите число: ");
int num = int.Parse(ReadLine()!);

Write($"[{string.Join(",", Fibonachi(num))}]");
//Write(num == 0 || num == 1?$"{num}":$"[{string.Join(",", Fibonachi(num))}]");

int[] Fibonachi(int inNum)                          //f(n)=f(n-1) + f(n-2), причем f(0)=0, а f(1)=1
{
    int[] result = new int[inNum];

    for (int i = 2; i < inNum; i++)
    {
        if (inNum == 0 || inNum == 1)
        {
            result[i] = inNum;
        }
        else
        {
            result[0] = 0;
            result[1] = 1;
            result[i] = result[i - 1] + result[i - 2];
        }
    }
    return result;
}