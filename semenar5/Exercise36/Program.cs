using static System.Console;
Clear();

int[] array = GetArray(6);
printArray(array);
int[] array2 = multiPara(array);
printArray(array2);

int[] GetArray(int size)
{
    int[] resultArray = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = rnd.Next(-10, 10);
    }
    return resultArray;
}

int[] multiPara(int[] array)
{
    int[] result = new int[1];
    for (int i = 1; i < array.Length; i++)
    {
        if(i %2 ==1)
        {
        result[0] += array[i];
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