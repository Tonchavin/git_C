using static System.Console;
Clear();

int[,] RandomMatrix = GetRandomMatrixArray();

PrintMatrixArray(RandomMatrix);
WriteLine();
PrintMatrixArray(GetReversMatrix(RandomMatrix));

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

int[,] GetReversMatrix(int[,] inRandomMatrix)
{
    int[] inReversMatrix = new int[inRandomMatrix.GetLength(1)];

    for (int i = 0; i < inRandomMatrix.GetLength(1); i++)
    {
        inReversMatrix[i] = inRandomMatrix[0, i];
        inRandomMatrix[0, i] = inRandomMatrix[inRandomMatrix.GetLength(0) - 1, i];
        inRandomMatrix[inRandomMatrix.GetLength(0) - 1, i] = inReversMatrix[i];    
    }
    return inRandomMatrix;
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