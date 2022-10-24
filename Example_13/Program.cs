//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.Через строку решать нельзя.

//645 -> 5

//78 -> третьей цифры нет

Console.WriteLine("Введите число.");
int num = int.Parse(Console.ReadLine()!);

void ThrirdNumber(int num)
{
    if (num < 99)
    {
        Console.WriteLine("Нет третьей цифры");
    }
    else
    {
        while (num > 1000)
        {
            num = num / 10;
        }
        Console.WriteLine(num % 10);
    }

}

ThrirdNumber(num);