// Задача 57: Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
int row = new Random().Next(5,5);
int col = new Random().Next(5,5);
int[,] array = new int[row, col];
FillArray(array);
PrintArray(array);
Console.WriteLine();
ModifyArray(array);
// PrintArray(array);
// Console.WriteLine();
void FillArray(int[,] arr)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 11);
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

void ModifyArray(int[,] arr)
{
    int[] num = new int[11];
    for (int row = 0; row < arr.GetLength(0); row++)
    {
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            num[arr[row, col]]++;
        }
    }
    for (int i = 0; i < num.Length; i++)
    {
        if (num[i] != 0)
            Console.WriteLine($"Число {i} повторяется {num[i]} раз(а)");
    }
}