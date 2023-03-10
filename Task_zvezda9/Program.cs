/*Задача со звездочкой: Пользователь вводит скобочные последовательности. В
последовательности могут встретиться скобки вида: {}, (), [].
Правильная скобочная последовательность - символьная последовательность,
составленная в алфавите, состоящем из символов, сгруппированных в
упорядоченные пары.
Пример правильной скобочной последовательности: (), ()[]{}
Пример неправильной: (], ({)}
Написать программу, которая определяет правильная ли скобочная
последовательность была введена*/

int StringOrder(string str)
{
    int count = 0;
    for (int i = 0; i < str.Length - 1; i += 2)
    {

        if (str[i] == '(' && str[i + 1] == ')' || str[i] == '[' && str[i + 1] == ']') count = 1;
        else count = 0;

    }

    return count;

}

void PrintMessage(int c)
{
    if (c == 1) Console.WriteLine("Последовательность верная");
    else Console.WriteLine("Последовательность неверная");
}

Console.Clear();
Console.Write("Введите скобочную последовательность из () или []: ");
string str = Console.ReadLine()!;

PrintMessage(StringOrder(str));




