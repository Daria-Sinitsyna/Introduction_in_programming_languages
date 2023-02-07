/*Напишите программу, которая принимает на вход
трёхзначное число и на выходе показывает вторую цифру этого
числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number <= 999 && number >= 100)
{
    int a = number / 10;
    a = a % 10;
    Console.WriteLine(a);
}
else Console.WriteLine("Вы ввели не трехзначное число");
