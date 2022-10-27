/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/ 

 Console.WriteLine("Введите число:");
string num = Console.ReadLine();
int len = num.Length;
if (len == 5)
{
    if (num[0] == num [4] && num [1] == num [3])
    {
        Console.WriteLine("Введенное число - палиндром");
    }       
    else
    {
        Console.WriteLine("Введенная число - не палиндром");
    }
}    