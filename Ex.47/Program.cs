/*
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/


int GetNumber(string message)
{
    int result = 0;
    string errorMessage = "Вы ввели не корректое число. Введите натуральное число";

    while(true)
    {
        
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result))
            break;
        else
        {
            Console.Clear();
            Console.WriteLine(errorMessage);
        }
    }
    return result;
}

void PrintArray(double [,] matr)
{
    for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            {
            Console.Write($"({matr[i,j]})");
            }
        Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Random random = new Random();
    for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            {

            matr[i,j] = 5 - random.Next(11) + random.NextDouble();
            }
    }
}


int m = GetNumber("Введите число столбцов массива");
int n = GetNumber("Введите число строк массива");

double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);
