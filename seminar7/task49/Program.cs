// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса не чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Новый массив будет выглядеть 
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4

int[,] arr = new int[3, 4];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
    }
}


PrintArr(arr);

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
            Console.Write($"{arr[i, j],4}");
            
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Новый массив будет выглядеть");
CreatArr(arr);

void CreatArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           if((i %2 !=0) && (j %2 !=0)) arr[i,j] = arr[i, j] * arr[i, j];

            Console.Write($"{arr[i, j],4}");
            
        }
        Console.WriteLine();
    }
}


