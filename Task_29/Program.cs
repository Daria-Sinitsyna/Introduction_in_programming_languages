/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Clear();

void Function(int N1)
{
    double[] array = new double[N1];
    for (int i = 0; i < N1; i++)
    {
        array[i] = new Random().Next(0, 101);
        Console.Write($"{array[i]}  ");
    }

}

Console.Write("Введите число A:  ");
int A = int.Parse(Console.ReadLine()!);

Function(A);
Console.WriteLine(" ");