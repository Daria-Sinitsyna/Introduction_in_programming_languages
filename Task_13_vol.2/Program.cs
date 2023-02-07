/* Напишите программу, которая выводит третью
цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Clear();

//Console.Write("Введите трехзначное число: ");
//int number = int.Parse(Console.ReadLine()!);
int number = new Random().Next(1, 10000);
Console.WriteLine(number);

if (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine(result);
}
else Console.WriteLine("нет третьей цифры");