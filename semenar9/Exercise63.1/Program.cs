using static System.Console;
Clear();

PrintNumbers(10);

void PrintNumbers(int num)
{
    if(num==1) Write(num);
    else 
    {
        PrintNumbers(num-1);
        Write($",{num}");
    }
}