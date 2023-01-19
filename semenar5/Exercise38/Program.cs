using static System.Console;
Clear();

double[] array = GetArray(4);
printArray(array);
double[] array2 = multiPara(array);
printArray(array2);

double[] GetArray(int size)
{
    double[] resultArray = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        resultArray[i] = Math.Round(rnd.NextDouble() * 10, 2);
    }
    return resultArray;
}

double[] multiPara(double[] array)
{
    double Min = array[0];
    double Max = array[0];
    double[] result = new double[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (Max < array[i])
        {
            Max = array[i];
        }
        if(Min > array[i])
        {
            Min = array[i];
        }
    }
    result[0] = Math.Round(Max - Min, 2);
    return result;
}

void printArray(double[] inArray)
{
    Write("[");
    for (int i = 0; i < inArray.Length - 1; i++)
    {
        Write($"{inArray[i]} ");
    }
    Write($"{inArray[inArray.Length - 1]}]"); //a = 5.465 print(round(a, 2)) //Math.Round
}