using static System.Console;
Clear();

// int[] array1 = { 1, 2, 3, 4, 5 };
// int[] ResArray = InitArray(); 
// PrintArray(ResArray);
// WriteLine();
// PrintArray(ChangeArray(array1));


// int[] InitArray()
// {
//     int[] array = new int[8];
//     Random rand = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(0, 2);
//     }
//     return array;
// }

// int[] ChangeArray(int[] arr)
// {
//     int[] array = new int[arr.Length];
//     Random rand = new Random();

//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(0, 2);
//     }
//     return array;
// }

// int[] ChangeArray(int[] arr)
// {
//     int[] array = new int[arr.Length];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if(arr[i] == 0)
//         {
//             arr[i] = 1;
//         }
//         else
//         {
//             arr[i] = 0;
//         }
//     }
//     return arr;
// }

// void PrintArray(int[] print)
// {
//     int count = print.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Write($"{print[i]}");
//     }
// }

int[] arr = GetArray(10);
int[] arr1 = new int [8];

FullArray(arr1);
PrintArray(arr1);

void FullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
}

int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(2);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
}
