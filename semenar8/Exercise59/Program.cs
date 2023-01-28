using static System.Console;
Clear();

int[,] RandomMatrix = GetRandomMatrixArray();

PrintMatrixArray(RandomMatrix);
WriteLine();
PrintMatrixArray(DelMatrixArray(RandomMatrix));

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

int[,] DelMatrixArray(int[,] inRandomMatrix)
{
    int minI = 0;
    int minJ = 0;
    int i1 = 0;
    int j1 = 0;
    int[,] resultArray = new int[inRandomMatrix.GetLength(0)-1, inRandomMatrix.GetLength(1)-1];
    for (int i = 0; i < inRandomMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inRandomMatrix.GetLength(1); j++)
        {
            if (inRandomMatrix[i, j] <= inRandomMatrix[minI, minJ])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    for (int i = 0; i < inRandomMatrix.GetLength(0)-1; i++)
    {
        if (i >= minI)
        {
            i1 = i + 1;
        }
        else
        {
            i1 = i;
        }
        for (int j = 0; j < inRandomMatrix.GetLength(1)-1; j++)
        {
            if (j >= minJ)
            {
                j1 = j + 1;
            }
            else
            {
                j1 = j;
            }
            resultArray[i, j] = inRandomMatrix[i1, j1];
        }
    }
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