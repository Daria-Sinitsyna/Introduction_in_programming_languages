/*Напишите программу, которая на вход принимает
два числа и выдает, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/

Console.Clear();

Console.Write("Введите первое число: ");
int number_1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int number_2 = int.Parse(Console.ReadLine()!);

if (number_1 > number_2)
{
    Console.Write($"Число {number_1} больше {number_2}");
}
else
{
    Console.Write($"Число {number_2} больше {number_1}");
}
Console.WriteLine(" ");