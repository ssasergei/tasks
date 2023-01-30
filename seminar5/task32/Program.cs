// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] array = new int[4];

FillArray(array);
Console.Write(" -> ");
ReverseElement(array);

void ReverseElement(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        Console.Write(array[i] + " ");
    }
    Console.Write("]\n");
}

void FillArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-4, 11);
        Console.Write(array[i] + " ");
    }
    Console.Write(" ]");
}

