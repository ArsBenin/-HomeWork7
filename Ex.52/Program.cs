/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void PrintArray(int [,] matr)
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

void FillArray(int[,] matr)
{
    for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            {
            matr[i,j] = new Random().Next(1,10);
            }
    }
}

void AverageColumns(int[,] matr)
{
    double average = 0;
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double summ = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
            {
            summ = summ + matr[i,j];
            }
        average = summ/matr.GetLength(0);
        Console.WriteLine($"Среднее арифметическое элементов столбца {j+1} равно {average}");
        Console.WriteLine();
    }
}

int m = GetNumber("Введите число строк массива");
int n = GetNumber("Введите число столбцов массива");
int [,] matrix = new int [m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
AverageColumns(matrix);


