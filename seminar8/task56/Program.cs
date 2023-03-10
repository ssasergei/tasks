// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int row = new Random().Next(3, 10);
int col = new Random().Next(2, 5);
int[,] array = new int[row, col];

FillArray(array);
PrintArray(array);
Console.WriteLine();
void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(1, 10);
        }
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine("");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5}");
        }
    }
}
// Программа считает сумму элементов в каждой 
int SumRow(int[,] arr)
{
    int[,] sumRows = new int[arr.GetLength(0), 2];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {           
            sum = sum + arr[i, j] ;            
        }
        sumRows[i, 0] = i;
        sumRows[i, 1] = sum;
     }          
    int minSum = 0;
    for (int i = 0; i < sumRows.GetLength(0); i++)
    {
        if (sumRows[i, 1] < sumRows[minSum, 1]) minSum = i;
    }
    
    return minSum;
}

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {SumRow(array)+1} строка ");