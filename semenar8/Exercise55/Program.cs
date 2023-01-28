using static System.Console;
Clear();

int[,] RandomMatrix = GetRandomMatrixArray();

PrintMatrixArray(RandomMatrix);
WriteLine();
PrintMatrixArray(GetRotateMatrix(RandomMatrix));

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

int[,] GetRotateMatrix(int[,] inRandomMatrix)
{
    int[,] inRotateMatrix = new int[inRandomMatrix.GetLength(0), inRandomMatrix.GetLength(1)];

    if (inRandomMatrix.GetLength(0) == inRandomMatrix.GetLength(1))
    {
        for (int i = 0; i < inRandomMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < inRandomMatrix.GetLength(1); j++)
            {
                inRotateMatrix[j, i] = inRandomMatrix[i, j];
            }
        }
        WriteLine($"Перевернутая матрица: ");
    }
    else
    {
        WriteLine($"Нельзя перевернуть матрицу: ");
        return inRandomMatrix;
    }
    return inRotateMatrix;
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