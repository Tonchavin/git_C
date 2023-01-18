using static System.Console;
Clear();

Write(FindArray(GetArray()));

int[] GetArray()
{
    int[] array = new int[20];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 200);
    }
    return array;
}

int FindArray(int[] arr)
{
    int count = 0;
    foreach (int i in arr)
    {
        if (i >= 10 && i <= 99)
        {
            count += 1;
        }
    }
    return count;
}