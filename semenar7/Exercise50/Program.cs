using static System.Console;
Clear();

Write("Введите позиции элемента в двумерном массиве через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int rows = Convert.ToInt32(parameters[0]);
int columns = Convert.ToInt32(parameters[1]);

int[,] array = GetMatrixArray();
int[,] FindNumberArray = new int[rows, columns];
int Number = FindNumber(FindNumberArray, array);

PrintMatrixArray(array);
WriteLine(Number != 0 ? $"Элемент с индексом rows:{rows} columns:{columns} = {Number}" : $"Элемент с индексом rows:{rows} columns:{columns} = нет");

int[,] GetMatrixArray()
{
    Random rnd = new Random();
    int SizeRows = rnd.Next(2, 6);
    int SizeColumns = rnd.Next(1, 8);
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

int FindNumber(int[,] inFindNumberArray, int[,] inArray)
{
    int Temp = 0;
    for (int i = rows, j = columns; rows < inArray.GetLength(0) && columns < inArray.GetLength(1); i++, j++)
    {
        if (i == rows && j == columns)
        {
            Temp = inArray[rows, columns];
            break;
        }
        else
        {
            Temp = 0;
            break;
        }
    }
    return Temp;
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