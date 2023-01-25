// Задача №18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Ввести четверть: ");
int num = Convert.ToInt32(Console.ReadLine());


// if (num==1) Console.Write("X>0 &&Y>0");
// else if (num==2) Console.Write("X<0 &&Y>0");
// else if (num==3) Console.Write("X<0 &&Y<0");
// else if (num==4) Console.Write("X>0 &&Y<0");
// else Console.Write("Ошиба ввода");


//Кейсы
switch (num)
{
    case 1:
    {
        Console.WriteLine("X>0 &&Y>0");
        break;
    }

    case 2:
    {
        Console.WriteLine("X<0 &&Y>0");
        break;
    }

    case 3:
    {
        Console.WriteLine("X<0 &&Y<0");
        break;
    }
    
    case 4:
    {
        Console.WriteLine("X>0 &&Y<0");
        break;
    }

    default:
    {
        Console.WriteLine("Нет данных");
        break;
    }
}

