using static System.Console;
Clear();

Write("Введите размер массива: ");
int array = int.Parse(ReadLine()!);
Write($"[{string.Join(",", CopyArray(GetArray(array)))}]");
//Write(CopyArray(GetArray(array)));

int[] GetArray(int inArray)
{
    Random rnd= new Random();
    int[]inArr = new int[inArray];
    for (int i = 0; i < inArray; i++)
    {
        inArr[i] = rnd.Next(1,10);
    }
    return inArr;
}

int[] CopyArray(int[] inArray)          //переварачивает массив,используется тогда когда оригинальный массив еще где то нужен
{
    for (int i = 0; i < inArray.Length; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[i];
        inArray[i] = temp;
    }
    return inArray;
}