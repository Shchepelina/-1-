/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

Console.WriteLine("Введите цифру -");
string userNumber = Console.ReadLine(); 
int dayNumber = int.Parse(userNumber);
if (dayNumber == 1) Console.WriteLine("Понедельник,");
if (dayNumber == 2) Console.WriteLine("Вторник");
if (dayNumber == 3) Console.WriteLine("Среда");
if (dayNumber == 4) Console.WriteLine("Четверг");
if (dayNumber == 5) Console.WriteLine("Пятница");
if (dayNumber == 6) Console.WriteLine("Суббота, Выходной день");
if (dayNumber == 7) Console.WriteLine("Воскресенье, выходной день");

