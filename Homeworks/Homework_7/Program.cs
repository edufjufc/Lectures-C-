﻿/*

// Задание 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] array= new double[rows, columns];

    for(int i=0; i<rows; i++) 
        for(int j=0; j<columns; j++) 
            array[i,j]=Math.Round((new Random().Next(minValue, maxValue+1) + new Random().NextDouble()),2);

    return array;
}

void Show2dArray(double[,] array)
{
    for(int i=0; i<array.GetLength(0); i++) 
    {
        for(int j=0; j<array.GetLength(1); j++) 
            Console.Write(array[i,j]+" ");
        
        Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

double[,] myArray=CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

*/

/*

// Задание 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array= new int[rows, columns];

    for(int i=0; i<rows; i++) 
        for(int j=0; j<columns; j++) 
            array[i,j]=new Random().Next(minValue, maxValue+1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++) 
    {
        for(int j=0; j<array.GetLength(1); j++) 
            Console.Write(array[i,j]+" ");
        
        Console.WriteLine();
    }
}

void FindPosition(int row, int column, int[,] array)
{
    if((row > (array.GetLength(0))-1) || (column > (array.GetLength(1)-1))) 
        Console.WriteLine("There is no number with such an index");
    else Console.WriteLine("There is a number on this position: " + array[row, column]);
}

Console.Write("Input a number of rows: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

int[,] myArray=CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);

Console.Write("Input a row of position: ");
int x=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a column of position: ");
int y= Convert.ToInt32(Console.ReadLine());
FindPosition(x, y, myArray);

*/

/*

// Задание 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array= new int[rows, columns];

    for(int i=0; i<rows; i++) 
        for(int j=0; j<columns; j++) 
            array[i,j]=new Random().Next(minValue, maxValue+1);

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++) 
    {
        for(int j=0; j<array.GetLength(1); j++) 
            Console.Write(array[i,j]+" ");
        
        Console.WriteLine();
    }
}

void ArithmeticalMean(int[,] array)
{
    Console.Write("Arithmetical Mean of сolumns: ");
        for(int j = 0; j< array.GetLength(1); j++)
        {
            double arithmeticalMean = 0;
            for(int i = 0; i< array.GetLength(0); i++)
            {
                arithmeticalMean += array[i, j];
            }
            Console.Write(Math.Round((arithmeticalMean / array.GetLength(0)), 1)+ " ");
    }
}

Console.Write("Input a number of rows: ");
int m=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

int[,] myArray=CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
ArithmeticalMean(myArray);

*/
