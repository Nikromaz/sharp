﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GetArray(int m, int n, int minValue, int maxValue) //функция создания двумерного массива
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    return result;
}

void PrintArray(int[,] inArray)//функция вывода массива на печать
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void GetAverageOfColumns(int[,] massive)//функция нахождения среднего арифметического в столбцах массива
{
    double[] arrayOfColumns = new double[massive.GetLength(1)];
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < massive.GetLength(0); i++)
        {
            sum += massive[i, j];
        }
        arrayOfColumns[j] = Math.Round(sum / massive.GetLength(0), 2);
    }
    Console.WriteLine($"Среднее арифметическое каждого столбца: [{String.Join("; ", arrayOfColumns)}]");
}

Console.Clear();
int row = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
int[,] array = GetArray(row, columns, 0, 10);
PrintArray(array);
GetAverageOfColumns(array);