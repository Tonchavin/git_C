using static System.Console;
Clear();

WriteLine("Введите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize);

//string stringArray = String.Join(",", array); 
//String.Join(",", array) - выводит массив
WriteLine($"[{String.Join(",", array)}]");

ReverseArray2(array);

WriteLine($"[{String.Join(",", array)}]");

//WriteLine($"[{String.Join(",", ReverseArray1(array))}]");

int[] GetArray(int size)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        resultArray[i] = new Random().Next(1, 10);
    }
    return resultArray;
}

// int[] ReverseArray1(int[] inArray)          
// {
//     int[] result = new int[inArray.Length];

//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result[i] = inArray[inArray.Length - 1 - i];
//     }
//     return result;
// }


void ReverseArray2(int[] inArray)          //переварачивает массив,используется тогда когда оригинальный массив еще где то нужен
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int temp = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = temp;
    }
}