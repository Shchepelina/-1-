/* Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */
Console.WriteLine("Введите три числа: -");
string numberAStr = Console.ReadLine();
string numberBStr = Console.ReadLine();
string numberCStr = Console.ReadLine(); 
int numberA = int.Parse(numberAStr); 
int numberB = int.Parse(numberBStr); 
int numberC = int.Parse(numberCStr); 
if (numberA > numberB && numberA > numberC)
{
    Console.WriteLine($"наибольшее число {numberA}");
}
if (numberB > numberA && numberB > numberC)
{
    Console.WriteLine($"наибольшее число {numberB}");
}
if (numberC > numberB && numberC > numberA)
{
    Console.WriteLine($"наибольшее число {numberC}");
}
