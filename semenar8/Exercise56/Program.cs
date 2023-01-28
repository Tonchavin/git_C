using static System.Console;
Clear();

int[,] Array = GetMatrixArray();
int[] sum = MinSumRowArray(Array);

PrintMatrixArray(Array);
WriteLine();
MinPrintSum(MinSumRowArray(Array));

int[,] GetMatrixArray()
{
    Random rnd = new Random();
    int SizeRows = rnd.Next(3, 6);
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

int[] MinSumRowArray(int[,] inArray)
{
    int k = inArray.GetLength(0);
    int[] resultArray = new int[k];
    int[] min = new int[2];

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            resultArray[i] += inArray[i, j];
        }
    }
    min[0] = resultArray[0];
    min[1] = 0;
    for (int i = 0; i < resultArray.Length; i++)
    {
        if (min[0] > resultArray[i])
        {
                min[0] = resultArray[i];
                min[1] = i;
        }
    }
    return min;
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

void MinPrintSum(int[] inArray)
{
    for (int i = 1; i < 2; i++)
    {
        Write($"Наименьшая сумма: {inArray[0],2} находится в строке: {inArray[1],2} ");
    }
}