// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите номер дня недели");
int a = Convert.ToInt32(Console.ReadLine());
if (a<=0 ||a>7) Console.WriteLine("такого дня недели не существует");
else if (a<6) Console.WriteLine("не выходной");
else Console.WriteLine("выходной");
