﻿// Сравнить числа, вывести большее.
Console.Write("Введите число a: ");
int a =  int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b =  int.Parse(Console.ReadLine());
Console.Write("Большее число: ");
if (a > b)
{
    Console.WriteLine(a);
}
else
{
    Console.WriteLine(b);
}