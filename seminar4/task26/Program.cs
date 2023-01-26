// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5


Console.WriteLine("Ведите число ");
string? num1 = Console.ReadLine();
int num = Convert.ToInt32(num1);


int count = 0;

while (num > 0)
{
    num /=10;
    count++;

}
Console.WriteLine(count);