﻿/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int AccermanFunction(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return AccermanFunction(n - 1, 1);
    else
      return AccermanFunction(n - 1, AccermanFunction(n, m - 1));
}


int userNumberM = GetNumber("Введите число M:");
int userNumberN = GetNumber("Введите число N:");
Console.Write(AccermanFunction(userNumberM, userNumberN));