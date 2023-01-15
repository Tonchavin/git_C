using static System.Console;
Clear();

int [] arr = new int[8];

GetArray(arr);
PrintArray(arr);

void GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,99);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
 
        Write($"{array[i]} ");
    }
}
