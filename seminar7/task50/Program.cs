// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
// 1 1 -> 9

Console.Write("Ввести значение 1 ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести значение 2 ");
int num2 = Convert.ToInt32(Console.ReadLine());
int m = 3;
int n = 4;
int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 100);
    }
}

PrintArr(arr);

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],4}");
        }
        Console.WriteLine();
    }
}
NumPrint(arr);

void NumPrint(int[,] arr)
{
    if ((m <= num1) || (n <= num2))
        Console.Write($"{num1} {num2} -> такого числа в массиве нет");
    else
        Console.WriteLine($" {num1} {num2} -> {arr[num1, num2]}");
}