// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Write("Введите чило: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write (SumNumbers(N));
int SumNumbers (int num)
{
    if (num==0) return num;
    return (num % 10 + SumNumbers(num/10));
}