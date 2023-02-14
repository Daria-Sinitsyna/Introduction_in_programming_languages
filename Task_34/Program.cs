/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Clear();

int[] GetArray(int size, int MinValue, int MaxValue)
{
    int[] Result = new int[size];

    for (int i = 0; i < size; i++)
    {
        Result[i] = new Random().Next(MinValue, MaxValue + 1);
    }
    return Result;
}

int Counter(int[] collection)
{
    int count = 0;

    foreach (int el in collection)
    {
        if (el % 2 == 0) count++;
    }
    return count;
}

int[] array = GetArray(new Random().Next(1, 11), 100, 999);
Console.WriteLine(String.Join(", ", array));


Console.WriteLine($"Количество четных элементов массиве: {Counter(array)}");