/*Задача 58: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.*/

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

int[,] MultiplyMatrix(int[,] A, int[,] B)
{
    int[,] result = new int[A.GetLength(0), B.GetLength(1)];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < B.GetLength(0); k++)
            {
                result[i, j] += A[i, k] * B[k, j];
            }

        }
    }
    return result;
}


Console.Clear();

Console.Write("Input rows for A matrix = ");
int rowA = int.Parse(Console.ReadLine()!);
Console.Write("Input collumns for A matrix = ");
int colA = int.Parse(Console.ReadLine()!);

int[,] matrixA = GetArray(rowA, colA, -10, 10);

Console.Write("Input rows for B matrix = ");
int rowB = int.Parse(Console.ReadLine()!);
Console.Write("Input collumns for B matrix = ");
int colB = int.Parse(Console.ReadLine()!);

int[,] matrixB = GetArray(rowB, colB, -10, 10);


PrintArray(matrixA);
Console.WriteLine("   ");
PrintArray(matrixB);

if (colA == rowB)
{
    Console.WriteLine("Произведение матриц возможно");
    int[,] result = MultiplyMatrix(matrixA, matrixB);
    PrintArray(result);

}
else Console.WriteLine("Введите корректную размерность матриц");


