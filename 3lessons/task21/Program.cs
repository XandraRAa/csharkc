/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. 

A(3,6); B(2,1) -> 5,09
A(7,-5); B(1,-1) -> 7,21
*/
Console.Clear();

Console.Write("Ведите X точки A:");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите Y точки A:");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите X точки B:");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите Y точки B:");
int yb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
Console.WriteLine(Math.Round(result, 2, MidpointRounding.ToZero)); 