﻿//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.



Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Четное число: ");

for (int i =1; i <= n; i=i+1)
if (i%2 == 0)
{
    Console.WriteLine(i + " "); 
}