﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Write("Введите длину массива:");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[num];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
    Console.Write($"{array[i]}, ");
}
Console.WriteLine("\b\b  ");