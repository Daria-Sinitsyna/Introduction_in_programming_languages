/*Задача 56: Задайте прямоугольный двумерный массив. Напишите
программу, которая будет находить строку с наименьшей суммой элементов.*/

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

int[] FindSumofString(int[,] Array_input)
{
    int sum = 0;
    int[] array1D = new int[Array_input.GetLength(0)];


    for (int i = 0; i < Array_input.GetLength(0); i++)
    {
        for (int j = 0; j < Array_input.GetLength(1); j++)
        {
            sum += Array_input[i, j];
        }
        array1D[i] = sum;
        sum = 0;
    }

    return array1D;
}

int[] FindMin(int[] Array_input1D)
{
    int min = Array_input1D[0];
    int temp = 0;
    int[] result = new int[2];

    for (int i = 0; i < Array_input1D.Length; i++)
    {
        if (Array_input1D[i] < min)
        {
            min = Array_input1D[i];
            temp = i;
        }
    }
    result[0] = temp;
    result[1] = min;
    return result;
}


void ResultMessage(int[] Array_result, int[,] Array_input)
{

    for (int j = 0; j < Array_input.GetLength(1); j++)
    {
        Console.Write($" {Array_input[Array_result[0], j]}\t ");
    }
    Console.WriteLine($"обладает минимальной суммой =  {Array_result[1]}");

}


Console.Clear();

Console.Write("Input rows = ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Input collumns = ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, col, -10, 10);
PrintArray(array);

int[] arrayofsum = FindSumofString(array);
//Console.WriteLine(String.Join(", ", arrayofsum));

//Console.WriteLine(String.Join(", ", FindMin(arrayofsum)));

ResultMessage(FindMin(arrayofsum), array);