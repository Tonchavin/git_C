using static System.Console;
Clear();

string result = GetNumbers(10);
Write(result);

// string GetNumbers(int num)
// {
//     if(num == 1) return num.ToString();
//     else         return $"{GetNumbers(num-1)},{num}";
// } 


//Сокращение кода

string GetNumbers(int num)
{
    return (num == 1) ? num.ToString() : $"{GetNumbers(num - 1)},{num}";
}