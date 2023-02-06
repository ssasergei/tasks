// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Ввидете колличество чисел M");

int countNuber = Convert.ToInt32(Console.ReadLine());


void InputNuber(int countNuber)
{
    int[] array = new int[countNuber];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Ввидете число M -> ");
        int number = Convert.ToInt32(Console.ReadLine());
        array[i] = number;
        if (array[i] > 0)
        count++;
        
    }
    Console.WriteLine($"Кол-во чисел больше 0 -> {count}");
}

InputNuber(countNuber);
