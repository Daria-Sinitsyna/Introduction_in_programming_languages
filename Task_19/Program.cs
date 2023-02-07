/* Напишите программу, которая принимает
на вход пятизначное число и проверяет, является ли
оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да*/

Console.Clear();

Console.Write("введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

while (number <= 9999 || number > 99999)
{
    Console.WriteLine("Вы ввели не пятизначное число ");
    Console.WriteLine("введите пятизначное число: ");
    number = int.Parse(Console.ReadLine()!);
}

int A = number % 10;
int A1 = number / 10000;
int B = number % 100 / 10;
int B1 = number / 1000 % 10;

if (A == A1 && B == B1) Console.WriteLine($"Число {number} это палиндром");
else Console.WriteLine($"Число {number} это не палиндром");