// //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// 2 x 2 x 2 x 2


Console.Write("Введите числа А: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите числа В: ");
int B = int.Parse(Console.ReadLine());

int count = B;
int result = 1;

for (int i = 0; i < count; i++)
{

    result *= A;
}

Console.WriteLine($"возводение числа {A} в натуральную степень {B} -> {result} ");