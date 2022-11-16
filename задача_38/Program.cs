/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.WriteLine("Введите размер массива ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
int max = 0;
int min = 0;
int diff = 0;
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);

min = numbers[0];
max = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] < min)
        min = numbers[i];
            
    if (numbers[i] > max)
        max = numbers[i];
}
Console.WriteLine();
Console.WriteLine("Max: " + max);
Console.WriteLine("Min: " + min);
 
for (int i = 1; i < numbers.Length; i++)
{
    diff = max - min;  
}
Console.WriteLine($"Разница между {max} и {min} равна {diff}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

