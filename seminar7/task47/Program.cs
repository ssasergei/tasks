// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// double x = Math.Round((new Random().NextDouble() * 10), 2); - заполненный случайными вещественными числами 

int m = 3;
int n = 4;

double[,] arr = new double[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = //new Random().Next(-9, 10);
        Math.Round((new Random().NextDouble() * 10), 1);
        
    }
}

PrintArr(arr);

void PrintArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],7}");
        }
        Console.WriteLine();
    }
}