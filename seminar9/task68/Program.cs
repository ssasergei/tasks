// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите чило M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите чило N: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write($"M = {num1}; N = {num2} -> A(m,n) = {FunctionAkkerman(num1, num2)}");

int FunctionAkkerman(int M, int N)
{
    if (M == 0) return N + 1;
    else if (N == 0) return (FunctionAkkerman(M - 1, 1));
    else return FunctionAkkerman(M - 1, FunctionAkkerman(M, N - 1));
}


