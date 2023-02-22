/*Задача 52: Задайте двумерный массив из целых чисел.
Найдите среднее арифметическое элементов в каждом
столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого
столбца: 4,6; 5,6; 3,6; 3.*/

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

double[] Average(int[,] Array_input)
{
    double[] avr = new double[Array_input.GetLength(1)];
    double temp;

    for (int j = 0; j < Array_input.GetLength(1); j++)
    {
        temp = 0;
        for (int i = 0; i < Array_input.GetLength(0); i++)
        {
            temp += Array_input[i, j];
        }
        avr[j] = Math.Round(temp / Array_input.GetLength(0), 2);
    }

    return avr;
}

void PrintAverageArray(double[] Array_Avr)
{
    Console.WriteLine(String.Join(", ", Array_Avr));
}

Console.Clear();

Console.Write("Input rows = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Input collumns = ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, col, -10, 9);
PrintArray(array);

Console.WriteLine(" ");

double[] new_array = Average(array);
PrintAverageArray(new_array);

