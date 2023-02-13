// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int row = new Random().Next(2, 2);
int col = new Random().Next(2, 2);
int[,] array1 = new int[row, col];
int[,] array2 = new int[row, col];
FillArray(array1);
FillArray(array2);
Console.Write("Например, даны 2 матрицы:");
PrintArray(array1);
Console.WriteLine("");
PrintArray(array2);
Multiply(array1, array2);
int[,] resultMatrix = Multiply(array1, array2);
Console.WriteLine();
Console.Write("Результирующая матрица будет:");
PrintArray(resultMatrix);
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
            Console.Write($"{arr[i, j],4}");
        }
    }
}

int[,] Multiply(int[,] arr1, int[,] arr2)
{
    int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {            
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                result[i,j] += arr1[i, k] * arr2[k, j];
            }
        } 
     } return result;
} 


