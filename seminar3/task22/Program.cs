// Задача №22
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


Console.Write("Ведите число ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num + "-> ");

for (int i = 0; i <= num; i++) //цикл for
{
    Console.Write($"{Math.Pow(i, 2)}" + ", ");
}
Console.WriteLine("\b\b  ");

