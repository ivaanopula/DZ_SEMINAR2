//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет



Console.WriteLine("Введите число от 1 до 7.");
int num = int.Parse(Console.ReadLine()!);
if (0 < num & num< 8)
{
    if (week(num))
    {
        Console.WriteLine("День недели не является выходным.");
    }
    else
    {

        Console.WriteLine("День недели является выходным.");
    }
    bool week(int num)
    {
        return (num < 6);
    }


} 
else
{
    Console.WriteLine("Введите число от 1 до 7.");
}
