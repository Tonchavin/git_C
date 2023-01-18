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
        resultArray[i] = rnd.Next(0, 10);
    }
    return resultArray;
}

int[] multiPara(int[] array)
{
    int size = array.Length / 2;
    if (array.Length % 2 == 1) size++;
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
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













// PrintArray(GetArray());
// WriteLine(ProgArray(GetArray()));

// int[] GetArray()
// {
//     int[] array = new int[10];
//     Random rnd = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rnd.Next(1, 10);
//     }
//     return array;
// }

// void PrintArray(int[] inArray)
// {
//     Write("[");
//     for (int i = 0; i < inArray.Length - 1; i++)
//     {
//         Write($"{inArray[i]},");
//     }
//     Write($"{inArray[inArray.Length - 1]}]");
// }

// int ProgArray(int[] arr,int ress)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         int res = 0;
//         if (i < arr.Length / 2 && arr.Length % 2 == 0)
//         {
//             res = arr[i] * arr[arr.Length - 1];
//             WriteLine(res);
//         }
//         return res;
//     }
// }