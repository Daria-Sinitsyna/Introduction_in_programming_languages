/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();

int Function(int N1)
{
    string number = N1.ToString();
    int L = number.Length;

    int temp = 0;
    int sum = 0;

    for (int i = 0; i < L; i++)
    {
        temp = int.Parse($"{number[i]}");
        sum += temp;
    }

    return sum;

}

Console.Write("Введите число A:  ");
int A = int.Parse(Console.ReadLine()!);

Console.WriteLine(Function(A));