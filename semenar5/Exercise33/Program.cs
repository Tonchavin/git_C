using static System.Console;
Clear();

Write("Введите искомое число в массиве: ");
int a = int.Parse(ReadLine()!);

Write(FindNumArray(GetArray()) ? "ДА" : "НЕТ");

int[] GetArray()
{
    int size = new Random().Next(2, 8);
    int[] arr = new int[size];
    Random rnd = new Random();
    Write($"[");
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(-10, 10);
        Write($"{arr[i]}, ");
    }
    Write($"{arr[size - 1]}");
    Write($"] ");
    return arr;
}

bool FindNumArray(int[] arr)
{
    foreach (int i in arr)
    {
        if (i == a)
            return true;
    }
    return false;
}


