// Задача №20.
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21
// x1-x2=n (в квадрате)
// y1-y2=m (в квадрате)
// n+m <- из этого корень




Console.Write("Ведите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

int num1 = x1 - x2;
int num2 = y1 - y2;
int sum = num1+ num2;

double sum1 = Math.Pow(num1, 2) + Math.Pow(num2, 2);

Console.WriteLine(Math.Sqrt(sum1));
