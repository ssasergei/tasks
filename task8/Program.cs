﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Ввести число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 2;
string result = " ";
while (count < number)
{
    result = result + count + ", ";
    count = count + 2;
}
Console.Write(number + " -> " + result);
Console.Write("\b\b  "); // удаление последний строчки