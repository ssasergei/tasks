// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine ("Введите пятизначное  число: ");
string? num = Console.ReadLine();

void CheckedNumber(string num)
{
      if (num[0] == num[4] && num[1] == num[3]) 
   {
       Console.WriteLine( num + " -> палиндромом");
   }

   else
   {
    Console.WriteLine(num + " -> не является палиндромом" );
   }
   
}

if (num?.Length == 5)
{
  CheckedNumber(num);
}

else Console.WriteLine("num + -> Введено неправильное число");


