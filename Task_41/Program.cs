/*Задача 41: Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3*/


Console.Clear();

int[] ReadArray(int number)
{
    int[] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        Console.WriteLine("Введите число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int Count(int[] array_input)
{
    int count = 0;
    for (int i = 0; i < array_input.Length; i++)
    {
        if (array_input[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Введите М чисел: ");
int M = int.Parse(Console.ReadLine()!);

int[] new_array = ReadArray(M);
Console.WriteLine(String.Join(", ", new_array));
Console.WriteLine($"Количество элементов больше 0 = {Count(new_array)}");


