/*Задача 54: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.*/

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

int[,] SortMaxtoMin(int[,] array_input)
{
    for (int i = 0; i < array_input.GetLength(0); i++)
    {
        for (int j = 0; j < array_input.GetLength(1); j++)
        {
            for (int k = 0; k < array_input.GetLength(1) - 1; k++)
            {
                if (array_input[i, k] < array_input[i, k + 1])
                {
                    int temp = array_input[i, k + 1];
                    array_input[i, k + 1] = array_input[i, k];
                    array_input[i, k] = temp;
                }
            }

        }
    }
    return array_input;
}


Console.Clear();

Console.Write("Input rows = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Input collumns = ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, col, -10, 10);
PrintArray(array);

Console.WriteLine(" ");
PrintArray(SortMaxtoMin(array));