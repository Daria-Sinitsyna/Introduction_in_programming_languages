/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

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

int FindDiff(int[] collection)
{
    int dif = 0;
    int max = collection[0];
    int min = collection[0];

    for (int i = 1; i < collection.Length; i++)
    {
        if (collection[i] > max) max = collection[i];
        else if (collection[i] < min) min = collection[i];
    }

    return dif = max - min;
}

int[] array = GetArray(new Random().Next(1, 11), -100, 100);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {FindDiff(array)}");