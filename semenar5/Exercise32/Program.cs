using static System.Console;
Clear();

PrintArray(RevGetArray(GetArray()));

int[] GetArray()
{
    int size = new Random().Next(2,8);
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-8, 8);
        Write($"{arr[i]} ");
    }
    return arr;
}

int[] RevGetArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Write($"{arr[i]},");
    }
    Write($"{arr[arr.Length - 1]}]");
}
