/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/ 

double GetDistanse(int x1, int y1, int x2, int y2, int z1, int z2 )
{
    double distanse = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2) + Math.Pow(z2 - z1, 2));
    return distanse;
}
int GetNumber (string message)
{
    int userNumber;
    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out int number))
        {
            userNumber = number;
            break;            
        }
        else
        {
             Console.WriteLine($"{number} не является числом. Повторите ввод\n");
        }
    }
    return userNumber;
}

int x1Number = GetNumber("Введите координату х1 - ");
int y1Number = GetNumber("Введите координату y1 - ");
int z1Number = GetNumber("Введите координату z1 - ");
int x2Number = GetNumber("Введите координату x2 - ");
int y2Number = GetNumber("Введите координату y2 - ");
int z2Number = GetNumber("Введите координату z2 - ");

double myDistance = GetDistanse(x1Number, y1Number, x2Number, y2Number, z2Number, z1Number);

Console.WriteLine($"Расстояние между точками [{x1Number}, {y1Number}, {z1Number}] и [{x2Number}, {y2Number}, {z2Number}] составляет {Math.Round(myDistance, 2)}.");