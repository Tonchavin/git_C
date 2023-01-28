using static System.Console;
Clear();

int[,] RandomMatrix1 = GetRandomMatrixArray1();
int[,] RandomMatrix2 = GetRandomMatrixArray2();
int[,] ProgMatrix = GetProgMatrix(RandomMatrix1, RandomMatrix2);

PrintMatrixArray(RandomMatrix1);
WriteLine();
PrintMatrixArray(RandomMatrix2);
WriteLine($"Результирующая матрица будет:");
WriteLine();
PrintMatrixArray(ProgMatrix);

int[,] GetRandomMatrixArray1()
{
    Random rnd = new Random();
    int row = rnd.Next(2, 3);
    int column = rnd.Next(2, 3);
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

int[,] GetRandomMatrixArray2()
{
    Random rnd = new Random();
    int row = rnd.Next(2, 3);
    int column = rnd.Next(2, 3);
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

int[,] GetProgMatrix(int[,] Matrix1, int[,] Matrix2)                //m3[0,0]=m1[0,0]*m2[0,0]+m1[0,1]*m2[1,0]
{                                                                   //m3[0,1]=m1[0,0]*m2[0,1]+m1[0,1]*m2[1,1]
    int[,] resultArray = new int[2, 2];                             //m3[1,0]=m1[1,0]*m2[0,0]+m1[1,1]*m2[1,0]
    for (int i = 0; i < Matrix1.GetLength(0); i++)                  //m3[1,1]=m1[1,0]*m2[0,1]+m1[1,1]*m2[1,1]
    {
        for (int j = 0; j < Matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < Matrix2.GetLength(0); k++)
            {                
            resultArray[i, j] += Matrix1[i, k] * Matrix2[k, j];
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