/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int SumOfNumbers(int m, int n)
{
    int sum = m;
    if (m == n) return 0;

    m++;
    sum = m + SumOfNumbers(m, n);

    //Console.WriteLine(sum);
    return sum;
}

Console.Clear();
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine(SumOfNumbers(M - 1, N));
