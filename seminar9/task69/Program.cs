// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.Write("Введите чило A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило B: ");
int B = Convert.ToInt32(Console.ReadLine());

Console.Write(MultiNubers(A,B));

int MultiNubers(int start, int end)
{    
    if (end==0) return 1;
    return (start * MultiNubers(start, end -1));
}