// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Ведите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7 )
    Console.WriteLine(num + " -> Да");
if (num < 6)
    Console.WriteLine(num + " -> Нет");
if (num < 1 || num > 7)
    Console.WriteLine(num + " -> Некорректный ввод");