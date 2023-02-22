/*Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и
возвращает значение этого элемента или же указание,
что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

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

int FindElement(int M_row, int N_col, int[,] Array_input)
{

    if (M_row < Array_input.GetLength(0) && N_col < Array_input.GetLength(1))
    {
        return Array_input[M_row, N_col];
    }
    else
    {
        return 0;
    }
}

void PrintResultMessage(int el)
{
    if (el == 0) Console.WriteLine("Такого элемента нет");
    else Console.WriteLine($"Искомый элемент - {el}");
}

Console.Clear();

Console.Write("Input rows = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Input collumns = ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, col, -10, 9);
PrintArray(array);

Console.Write("Введите номер строки (отсчет с 0) = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбца (отсчет с 0) = ");
int N = int.Parse(Console.ReadLine()!);

int element = FindElement(M, N, array);
PrintResultMessage(element);

