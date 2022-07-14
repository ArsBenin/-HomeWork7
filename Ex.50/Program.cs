/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

void FindElement(int[,] matr, int column, int line)
{
        if(matr.GetLength(0)<(column-1) || matr.GetLength(1)<(line-1))
    {
        Console.WriteLine($"Элемента позиции [{column},{line}] в массиве нет");
    }
        else
    {
        Console.WriteLine($"Элемент позиции [{column},{line}] равен {matr[column-1,line-1]}");
    }
    /*for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
            {
            if (i==column && j==line)
            {
                Console.WriteLine($"Элемент позиции [{i},{j}] равен {matr[i,j]}");
                break;
            }
                else
            {
                Console.WriteLine($"Элемента позиции [{column},{line}] в массиве нет");
            }
    }
}*/
}

int m = GetNumber("Введите число строк массива");
int n = GetNumber("Введите число столбцов массива");
int [,] table = new int [m, n];
FillArray(table);
PrintArray(table);
int column = GetNumber("Введите столбец элемента массива");
int line = GetNumber("Введите строку элемента массива");
FindElement(table,line,column);

