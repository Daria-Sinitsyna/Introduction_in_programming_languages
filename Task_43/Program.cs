/*Задача 43. Напишите программу, которая найдёт точку
пересечения двух прямых, заданных уравнениями y = k1 *
x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 =
9 -> (-0,5; -0,5)*/

Console.Clear();

double FindCrossPoint_x(double k1, double b1, double k2, double b2)
{
    double right_side = k1 - k2;
    double left_side = b2 - b1;
    double x_res = left_side / right_side;
    double y_res = k1 * x_res + b1;
    return x_res;
}

double FindCrossPoint_y(double X_res, double k1, double b1)
{
    double y_res = k1 * X_res + b1;
    return y_res;
}

Console.Write("Введите К_1: ");
double K_1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите B_1: ");
double B_1 = double.Parse(Console.ReadLine()!);
Console.Write("Введите К_2: ");
double K_2 = double.Parse(Console.ReadLine()!);
Console.Write("Введите B_2: ");
double B_2 = double.Parse(Console.ReadLine()!);

double result_x = FindCrossPoint_x(K_1, B_1, K_2, B_2);
double result_y = FindCrossPoint_y(result_x, K_1, B_1);

Console.WriteLine($"{result_x}, {result_y}");