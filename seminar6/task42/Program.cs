﻿// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10


// Console.WriteLine("Введите число:  ");
// int a = Convert.ToInt32(Console.ReadLine());

// int[] result = new int[32];

// int i = 0;
// while (a % 10 > 0)
// {
//    int Ostatok = a % 2;
//    if (Ostatok == 0)  result[i] = Ostatok;
//    else result [i] =1;
//    i++;
//    a = a / 2;  
// }

// void ReversArray(int[] arr)
// {
//     for (int j = i - 1; j >= 0; j--)
//     {
//         Console.Write($"{arr[j]} ");
//     }
// }

// ReversArray(result);








// Console.Write("Введите десятичное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// string binaryNum = ToBinary(num);
// Console.Write($"{num} -> ");
// PrintReverseString(binaryNum);

// string ToBinary(int num)
// {
//     string result = string.Empty;
//     while (num != 1)
//     {
//         result += num % 2;
//         num /= 2;
//     }
//     result += 1;

//     return result;
// }

// void PrintReverseString(string str)
// {
//     for (int i = str.Length - 1; i >= 0; i--)
//     {
//         Console.Write(str[i]);
//     }
// }



Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write($"{num} -> ");

int[] PrintArray(int num)
{
    int count = 0;
    while (num > 0)
    {
        num = num / 2;
        count++;  
    }
    int[] array = new int[count];
    return array;
}
int[] array = PrintArray(num);

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++, num /= 2)
    {
        array[i] = num % 2;
    }
}

void ReverseArray(int[] array)
{
    for (int i = array.Length - 1; i >= 0; i--) Console.Write($"{array[i]}");
}

FillArray(array);
ReverseArray(array);