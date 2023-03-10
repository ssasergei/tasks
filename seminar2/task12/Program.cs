// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

Console.WriteLine("Ввести два числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = number1 % number2;

if (sum == 0)
{
    Console.Write("кратно");
}
else
{
    Console.Write("не кратно -> ");
}

Console.WriteLine (sum);