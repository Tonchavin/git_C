using static System.Console;
Clear();

int[,] Array = GetMatrixArray();
int[] sum = SumColumnsArray(Array);

PrintMatrixArray(Array);
WriteLine();
PrintSum(sum);

int[,] GetMatrixArray()
{
    Random rnd = new Random();
    int SizeRows = rnd.Next(2, 6);
    int SizeColumns = rnd.Next(2, 8);
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

int[] SumColumnsArray(int[,] inArray)
{
    int k = inArray.GetLength(1);
    int[] resultArray = new int[k];
   
    for (int j = 0; j < inArray.GetLength(0); j++)
    {
        for (int i = 0; i < inArray.GetLength(1); i++)
        {
        resultArray[i] += inArray[j, i];         
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

void PrintSum(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Write($"{inArray[i],5} ");
    }
}