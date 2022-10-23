/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трехзначное число: ");
string numberA = Console.ReadLine();
int number = int.Parse(numberA);
if (number >= 100 && number <= 999 || number <= - 100 && number >= - 999 )
{
    int result = Math.Abs((number/10)%10); // модуль! когда на выходе получается -число, нужно взять модуль числа
    
    Console.WriteLine($"Вторая цифра трехначного числа {result}");
}
else
{
    Console.WriteLine($"данные не верны");
}

