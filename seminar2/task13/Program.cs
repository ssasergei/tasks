// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Ввести число: ");
int number = Convert.ToInt32(Console.ReadLine());

//перевод числа в массив
string num = number.ToString(); 
int[] array = new int[num.Length];

if (num.Length < 3) 
{
       Console.WriteLine( number + " -> третьей цифры нет");
}
else
 {
    Console.WriteLine(number + " ->" + num[2]);
 }