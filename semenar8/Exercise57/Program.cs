using static System.Console;
Clear();

int[,] RandomMatrix = GetRandomMatrixArray();

PrintMatrixArray(RandomMatrix);
WriteLine();
WriteLine (CountNumberArray(RandomMatrix));

int[,] GetRandomMatrixArray()
{
    Random rnd = new Random();
    int row = rnd.Next(2, 6);
    int column = rnd.Next(2, 6);
    int[,] resultArray = new int[row, column];

    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
        }
    }
    return resultArray;
}

int[] CountNumberArray(int[,] inRandomMatrix)
{
    int[] resultArray = new int[10];
    for (int i = 0; i < inRandomMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inRandomMatrix.GetLength(1); j++)
        {
            resultArray[inRandomMatrix[i, j]]++;
        }
    }
    for (int k = 0; k < 10; k++)
        WriteLine(resultArray[k]!=0?$"Чисел " + k + ": " + resultArray[k]:$"Чисел " + k + ": 0");

return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],5} ");
        }
        WriteLine();
    }
}