/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/

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

int Sum(int[] collection)
{
    int sum = 0;

    for (int i = 1; i < collection.Length; i += 2)
    {
        sum += collection[i];
    }
    return sum;
}



int[] array = GetArray(new Random().Next(1, 11), 1, 100);

Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Сумма элементов на нечетных позициях = {Sum(array)}");

