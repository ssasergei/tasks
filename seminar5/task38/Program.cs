// Задача 38: Задайте массив целых чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



int[] array = new int[4];
Console.Write("[ ");
PrintArray(array);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
        Console.Write($"{array[i]} , ");
    }
    Console.Write("\b\b ]");
}

int min = array[0];
int max = array[0];
      
    {
        for (int i = 0; i < array.Length; i++)

        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
            //diff = max - min;
        }
    }

int diff = 0;
diff = max - min;

Console.WriteLine($" -> {diff} ");