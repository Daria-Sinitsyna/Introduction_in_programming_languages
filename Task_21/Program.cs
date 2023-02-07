/*Напишите программу, которая принимает
на вход координаты двух точек и находит расстояние
между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();

Console.Write("Введите Ха:  ");
double Xa = double.Parse(Console.ReadLine()!);
Console.Write("Введите Yа:  ");
double Ya = double.Parse(Console.ReadLine()!);
Console.Write("Введите Zа:  ");
double Za = double.Parse(Console.ReadLine()!);

Console.Write("Введите Хb:  ");
double Xb = double.Parse(Console.ReadLine()!);
Console.Write("Введите Yb:  ");
double Yb = double.Parse(Console.ReadLine()!);
Console.Write("Введите Zb:  ");
double Zb = double.Parse(Console.ReadLine()!);

double distance_AB = Math.Pow(Math.Pow(Xb - Xa, 2) + Math.Pow(Yb - Ya, 2) + Math.Pow(Zb - Za, 2), 0.5);

Console.WriteLine($"{distance_AB:f2}");
