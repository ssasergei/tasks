// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//sqrt{(x_2-x_1)^2+(y_2-y_1)^2+(z_2-z_1)^2}


Console.Write("Введите точку А: ");
string[] arr1 = Console.ReadLine().Split(','); //ввод через ,
Console.Write("Введите точку B: ");
string[] arr2 = Console.ReadLine().Split(',');
int x1 = int.Parse(arr1[0]);
int y1 = int.Parse(arr1[1]);
int z1 = int.Parse(arr1[2]);
int x2 = int.Parse(arr2[0]);
int y2 = int.Parse(arr2[1]);
int z2 = int.Parse(arr2[2]);

int razx = x1 - x2;
int razy = y1 - y2;
int razz = z1 - z2;

double razall = Math.Pow(razx, 2) + Math.Pow(razy, 2) + Math.Pow(razz, 2);
double fin = Math.Sqrt(razall);

Console.WriteLine("A (" + x1 + "," + y1 + "," + z1 + "); B (" + x2 + "," + y2 + "," + z2 +  ") -> " + Math.Round(fin,2));