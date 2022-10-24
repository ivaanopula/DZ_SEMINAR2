//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Через строку решать нельзя.
//456 -> 5


Console.WriteLine("Введите от [100 до 999] число.");
int num = int.Parse(Console.ReadLine()!);


void res(int num)
{
    int firstdigit = num / 100;
    int secondDigit = (num - firstdigit * 100) / 10;
    Console.WriteLine("Вторая цифра числа :" + secondDigit);
   
}

 res(num);