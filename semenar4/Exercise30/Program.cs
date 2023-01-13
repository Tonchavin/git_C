using static System.Console;
Clear();

int[] resultArray = InitArray();
PrintArray(resultArray);

int[] InitArray()
{
    int[] array = new int[8];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 2);
    }
    return array;
}

void PrintArray(int[] print)
{
    int count = print.Length;
    
    for (int i = 0; i < count; i++)
    {
        Write($"{print[i]}");
    }
}
