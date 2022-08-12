Console.WriteLine("Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

Console.WriteLine("Введите координаты точки A (X, Y, Z)");
Console.Write("X = : ");
int ax = int.Parse(Console.ReadLine());
Console.Write("Y = : ");
int ay = int.Parse(Console.ReadLine());
Console.Write("Z = : ");
int az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B (X, Y, Z)");
Console.Write("X = : ");
int bx = int.Parse(Console.ReadLine());
Console.Write("Y = : ");
int by = int.Parse(Console.ReadLine());
Console.Write("Z = : ");
int bz = int.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(ax - bx, 2) + Math.Pow(ay - by, 2) + Math.Pow(az - bz, 2));
Console.WriteLine("Расстояние: " + Math.Round(AB, 2));