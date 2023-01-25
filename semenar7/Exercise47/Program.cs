using static System.Console;
Clear();

Write("Введите размер матрицы через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

double[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]));

PrintMatrixArray(array);

double[,] GetMatrixArray(int rows, int columns)
{
    Random rnd = new Random();
    Random rndNum = new Random();
    double[,] resultArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = Math.Round(rnd.NextDouble()*rndNum.Next(-10,10), 1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(double[,] inArray)
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