// Задача 28: Напишите программу, которая принимает
//  на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

Console.WriteLine("Ведите число ");
int N = Convert.ToInt32(Console.ReadLine());

int MultiPly(int num)
{
    int start = 1;
    for (int i = 1; i <= num; i++)
    {
        start = i * (start);
    }
    return start;
}
Console.WriteLine($"Произведение чисел  от 1 до {N} равна {MultiPly(N)} ");