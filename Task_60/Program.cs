/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся
двузначных чисел. Напишите программу, которая будет построчно выводить
массив, добавляя индексы каждого элемента.*/


int[,,] FillArray(int a1, int a2, int a3)
{
    int temp = 10;
    int[,,] array = new int[a1, a2, a3];

    for (int i = 0; i < a1; i++)
    {
        for (int j = 0; j < a2; j++)
        {
            for (int k = 0; k < a3; k++)
            {
                array[k, i, j] += temp;
                temp += 2;
            }
        }
    }

    return array;
}

void PrintIndex(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]}  ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Input 1D for A matrix = ");
int A1 = int.Parse(Console.ReadLine()!);
Console.Write("Input 2D for A matrix = ");
int A2 = int.Parse(Console.ReadLine()!);
Console.Write("Input 3D for A matrix = ");
int A3 = int.Parse(Console.ReadLine()!);

int[,,] array3D = FillArray(A1, A2, A3);


PrintIndex(array3D);
