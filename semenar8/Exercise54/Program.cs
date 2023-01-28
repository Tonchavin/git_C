using static System.Console;

Clear();

int[,] Array = GetMatrixArray();
int[,] MaxValue = FindMaxValue(Array);

PrintMatrixArray(Array);
WriteLine();
PrintMatrixArray(FindMaxValue(Array));

int[,] GetMatrixArray()
{
    Random rnd = new Random();
    int SizeRows = rnd.Next(2, 6);
    int SizeColumns = rnd.Next(2, 5);
    int[,] resultArray = new int[SizeRows, SizeColumns];
    for (int i = 0; i < SizeRows; i++)
    {
        for (int j = 0; j < SizeColumns; j++)
        {
            resultArray[i, j] = rnd.Next(1, 10);
        }
    }
    return resultArray;
}

int[,] FindMaxValue(int[,] inArray)
{
    int row = inArray.GetLength(0);
    int column = inArray.GetLength(1);
    int[,] resultArray = new int[row, column];
    int temp = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            resultArray[i,j] = inArray[i,j];
            for (int m = 0; m < column - 1; m++)
            {
                if (resultArray[i, m] < resultArray[i, m + 1])
                {
                    temp = resultArray[i, m + 1];
                    resultArray[i, m + 1] = resultArray[i, m];
                    resultArray[i, m] = temp;
                }
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
