﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("введите число");
int a = Math.Abs(Convert.ToInt32(Console.ReadLine()));
if (a<100)
{
    Console.WriteLine("нет здесь третьей цифры");
}
else
{
    while (a>999)
    {
        a=a/10;//откидываем последнюю цифру
    }
    Console.WriteLine("третья цифра "+a%10);
}

