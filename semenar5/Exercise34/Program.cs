using static System.Console;
Clear();

int[] array = GetArray(4);
printArray(array);
int[] array2 = multiPara(array);
printArray(array2);

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(99, 1000);
    }
    return resultArray;
}

int[] multiPara(int[] array)
{
    int[] result = new int[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result[0] += 1;
        }
    }
    return result;
}

void printArray(int[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]},");
    }
    Write($"{inArray[inArray.Length - 1]}]");
}