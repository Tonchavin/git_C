using static System.Console;
Clear();

WriteLine($"Введите размер массива X x Y x Z: ");
WriteLine($"Введите размер массива X: ");
int x = Convert.ToInt32(ReadLine()!);
WriteLine($"Введите размер массива Y: ");
int y = Convert.ToInt32(ReadLine()!);
WriteLine($"Введите размер массива Z: ");
int z = Convert.ToInt32(ReadLine()!);
WriteLine();

int[,,] Array3D = new int[x, y, z];
GetArray(Array3D);
PrintArray(Array3D);

void PrintArray(int[,,] Array3D)
{
    for (int i = 0; i < Array3D.GetLength(0); i++)
    {
        for (int j = 0; j < Array3D.GetLength(1); j++)
        {
            for (int k = 0; k < Array3D.GetLength(2); k++)
            {
                Write($"{Array3D[i, j, k]} = ({i},{j},{k}) ");
            }
            WriteLine();
        }
    }
}

void GetArray(int[,,] Array3D)
{
    int[] resultArray = new int[Array3D.GetLength(0) * Array3D.GetLength(1) * Array3D.GetLength(2)];
    int number = 0;
    Random rnd = new Random();
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        resultArray[i] = rnd.Next(10, 100);
        number = resultArray[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (resultArray[i] == resultArray[j])
                {
                    resultArray[i] = rnd.Next(10, 100);
                    j = 0;
                    number = resultArray[i];
                }
                number = resultArray[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < Array3D.GetLength(0); x++)
    {
        for (int y = 0; y < Array3D.GetLength(1); y++)
        {
            for (int z = 0; z < Array3D.GetLength(2); z++)
            {
                Array3D[x, y, z] = resultArray[count];
                count++;
            }
        }
    }
}
