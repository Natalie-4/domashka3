/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Введите координаты трёх точек в трёхмерном пространстве: ");
Console.WriteLine("Введите координату x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));


Console.WriteLine(distance);