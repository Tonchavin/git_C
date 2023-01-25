using static System.Console;
Clear();

int[,] array = GetMatrixArray(4, 4);
PrintMatrixArray(array);

int[,] GetMatrixArray(int rows, int columns)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
            if (i != 0 && i % 2 == 0 && j != 0 && j % 2 == 0)
            {
                resultArray[i, j] = resultArray[i, j] * resultArray[i, j];
            }

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