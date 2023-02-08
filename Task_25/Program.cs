/*Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

Console.Clear();
double Function(double N1, int N2)
{
    double result = Math.Pow(N1, N2);
    return result;
}

Console.Write("Введите число A:  ");
double A = double.Parse(Console.ReadLine()!);
Console.Write("Введите число B:  ");
int B = int.Parse(Console.ReadLine()!);


Console.WriteLine($"{A}^{B} = {Function(A, B)}");