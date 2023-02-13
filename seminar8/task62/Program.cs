// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();
int[,] array = FillArray(4, 4);
PrintArray(array);
int[,] FillArray(int row, int col)
{
    int[,] arr = new int[row, col];
    int count = 1;
    int step = arr.GetLength(0);
    for (int i = 0; i < step; i++)
    {
        //право
        for (int j = i; j < arr.GetLength(1) - i; j++)
        {
            arr[i, j] = count;
            count++;
        }
        // низ
        for (int j = i + 1; j < arr.GetLength(0) - i; j++)
        {
            arr[j, arr.GetLength(1) - 1 - i] = count;
            count++;
        }
        // лево
        for (int j = arr.GetLength(1) - 2 - i; j >= i; j--)
        {
            arr[arr.GetLength(1) - 1 - i, j] = count;
            count++;
        }
        //верх
        for (int j = arr.GetLength(1) - 2 - i; j > i; j--)
        {
            arr[j, i] = count;
            count++;
        }
    }
    return arr;
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
    }
}