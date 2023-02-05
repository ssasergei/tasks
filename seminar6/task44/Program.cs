// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Ведите число");
// int num = Convert.ToInt32(Console.ReadLine());
 
// //int Fibonacci = 0;
// int Fibonacci(int n);
// {
//  if(n == 1 || n == 2) return 1;
//  else return Fibonacci(n-1) + Fibonacci(n-2);
// }
// for (int i = 1; i < num; i++)
// {
//  Console.WriteLine(Fibonacci(i));
// }


Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int result = 1;
int pred = 1;
int predpred = 0;

for (int i = 0; i < N-1; i++)
{
    if (i == 0) Console.Write($"{i} ");
    if (i == 1) Console.Write($"{i} ");
    else 
    {
     result = pred + predpred;
     predpred = pred;
     pred = result;
     Console.Write($"{result} ");
    }
}

// Console.Write("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.Write($"Если N = {num} -> ");

// int[] Fibonacci(int num)
// {
//     int[] array = new int[num];
//     array[0] = 0;
//     array[1] = 1;
//     for (int i = 2; i < array.Length; i++)
//     {
//         array[i] = array[i - 2] + array[i - 1];
//     }
//     return array;
// }
// Console.Write(string.Join(" ", Fibonacci(num)));
