﻿/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */ 

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()); 
for(int i = 1; i <= number; i++)
if (i % 2 == 0)
{
   Console.Write($"числа {i}  ");
}