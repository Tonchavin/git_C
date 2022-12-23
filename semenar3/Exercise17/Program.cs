using static System.Console;
Clear();

WriteLine("Введите номер четверти: ");
int a = int.Parse(ReadLine()!);

// Первое решение,через if(условие)
//if (a < 1 || a > 4){WriteLine("Такой четверти нет,введите от 1 до 4!"); return;}
//if (a == 1){WriteLine("x > 0 и y > 0");}
//if (a == 2){WriteLine("x < 0 и y > 0");}
//if (a == 3){WriteLine("x < 0 и y < 0");}
//if (a == 4){WriteLine("x > 0 и y < 0");}

// Второе решение,через 
switch(a)
{
    case 1:
    {
        WriteLine("x > 0 и y > 0");
        break; 
    }
    case 2:
    {
        WriteLine("x < 0 и y > 0");
        break;  
    }
    case 3:
    {
        WriteLine("x < 0 и y < 0");
        break; 
    }
    case 4:
    {
        WriteLine("x > 0 и y < 0");
        break; 
    }
    default:
    {
        WriteLine("Такой четверти нет,введите от 1 до 4!");
        break;
    }
}
