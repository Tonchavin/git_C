using static System.Console;
Clear();

Write("Введите размер матрицы и диапозон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
//  string[] parameters = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries),int.Parse);    //конвертация строки в целочислиный массив
//  string[] parameters = Array.ConvertAll(ReadLine()!.Split(new char[]{'\"','#','$',':'}, StringSplitOptions.RemoveEmptyEntries),int.Parse);

//  int[] intParams = Array.ConvertAll(parameters,Convert.ToInt32);   //конвертация строки в конвертация строки в целочислиный массив
//  int[] intParams = Array.ConvertAll(parameters,Convert.int.Parse); //конвертация строки в конвертация строки в целочислиный массив(2 способ)

int[,] array = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]), int.Parse(parameters[2]), int.Parse(parameters[3]));
//int[,] array = GetMatrixArray(intParams[0], intParams[1], intParams[2], intParams[3]);
PrintMatrixArray(array);

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[,] resultArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resultArray[i, j] = rnd.Next(minValue, maxValue + 1);
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