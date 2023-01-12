using static System.Console;
Clear();

string text = "Дан текст.В тексте нужно все пробелы заменить черточками,маленькие буквы к заменить большими К,а большие С маленькими с. ";

// string s = "qwerty";
//             0123
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '-');

WriteLine(newText);
WriteLine();
newText = Replace(text, 'к', 'К');
WriteLine(newText);
WriteLine();
newText = Replace(text, 'С', 'с');
WriteLine(newText);
