// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите чило M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {M}; N = {N} -> {PrintNubers(M, N)}");

int PrintNubers(int start, int end)
{
    if (start == end) return start;
    return (start + PrintNubers(start + 1, end));
}