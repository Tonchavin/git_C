using static System.Console;
Clear();

PrintNumbers(2,8);

void PrintNumbers(int min,int max)
{
    if(max==min) Write(max);
    else 
    {
        PrintNumbers(min,max-1);
        Write($",{max}");
    }
}