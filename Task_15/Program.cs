﻿/*Напишите программу, которая принимает на вход
цифру, обозначающую день недели, и проверяет, является ли
этот день выходным.
6 -> да
7 -> да
1 -> нет*/

Console.Clear();

int day = new Random().Next(1, 8);
Console.WriteLine(day);

if (day > 5)
{
    if (day == 6) Console.WriteLine("Сегодня выходной! Это суббота!");
    else Console.WriteLine("Сегодня выходной! Это воскресенье!");
}
else Console.WriteLine("Сегодня рабочий день! Иди доделывай домашку!");