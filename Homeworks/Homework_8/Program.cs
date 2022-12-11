/*

// Задание 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

void Sorting(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int sortedSize=0; sortedSize < array.GetLength(1); sortedSize++)
        {
            for(int j = 0; j< array.GetLength(1)-1-sortedSize; j++)
            {
                if(array[i,j] > array[i,j+1])
                {
                int t = array[i, j+1];
                array[i,j+1] = array[i,j];
                array[i,j] = t;
                }
            }
        }
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
Console.WriteLine();
Sorting(myArray);
Show2dArray(myArray);

*/

/*

// Задание 2. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

int FindMinSumm(int[,] array)
{
    int minSum=100000000;
    int row=0;

    for(int i=0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j=0; j < array.GetLength(1); j++) sum+=array[i,j];
        if(sum<minSum) 
        {
            minSum=sum;
            row=i;
        }
    }
    return row;
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
int rowOfMinSum=FindMinSumm(myArray);
Console.Write("The minimum amount in the line under the number: "+ rowOfMinSum);

*/

/*

// Задание 3. Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

void CalculateProduct(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    if(array1.GetLength(1) == array2.GetLength(0))
    {
        for(int i=0; i < array1.GetLength(0); i++)
        {
            for(int l=0; l < array2.GetLength(1); l++)
            {
                int prod = 0;
                for(int j=0; j < array1.GetLength(1); j++) prod += array1[i,j]*array2[j,l];
                array3[i,l] = prod;
                Console.Write(prod + " ");
            }
        Console.WriteLine();
        }
    }
    else Console.WriteLine("Wrong size of arrays");
}

Console.Write("Input a number of rows of first matrix: ");
int m1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums of first matrix: ");
int n1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of first matrix: ");
int min1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of first matrix: ");
int max1=Convert.ToInt32(Console.ReadLine());

int[,] myArray1=CreateRandom2dArray(m1, n1, min1, max1);
Show2dArray(myArray1);


Console.Write("Input a number of rows of second matrix: ");
int m2=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of colums of second matrix: ");
int n2=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value of second matrix: ");
int min2=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value of second matrix: ");
int max2=Convert.ToInt32(Console.ReadLine());

int[,] myArray2=CreateRandom2dArray(m2, n2, min2, max2);
Show2dArray(myArray2);

Console.WriteLine();
CalculateProduct(myArray1, myArray2);

*/

/*

// Задание 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandom3dArray(int rows, int columns, int layers, int minValue, int maxValue)
{
    int[,,] array = new int[rows, columns, layers];
    int[] numberArray = new int[maxValue - minValue + 1];
    
    for(int i = 0; i < (maxValue - minValue + 1); i++) numberArray[i] = minValue + i;

    for (int i = 0; i < (maxValue - minValue + 1); i++)
    {
        int iChange1 = new Random().Next(0, maxValue - minValue + 1);   
        int iChange2 = new Random().Next(0, maxValue - minValue + 1);
        int temp = numberArray[iChange1];
        numberArray[iChange1] = numberArray[iChange2];
        numberArray[iChange2] = temp;
    }
    for(int h = 0; h < maxValue - minValue + 1;h++)
    {
        Console.Write(numberArray[h] + " ");
    }
    Console.WriteLine();
    int x = 0;
    for(int i = 0; i<rows; i++)
    {
        for(int j = 0; j< columns; j++)
        {
            for (int k = 0; k < layers; k++)
            {
                array[i,j,k] = numberArray[x];
                x++;
            }        
        }      
    }
    return array;
}

void Show3dArray(int[,,] array)
{
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++)
        {
            for (int k = 0; k< array.GetLength(2); k++)
            {
                Console.Write(array[i,j,k] + "  " + "(" + i + ", " + j + ", "+ k + ") ");
            }
            Console.WriteLine();
        }
    Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of layers: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Input mininmum of value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum of value: ");
int max = Convert.ToInt32(Console.ReadLine());

if(m*n*r < (max-min))
{
    int[,,] myArray = CreateRandom3dArray(m, n, r, min, max);
    Show3dArray(myArray);
}
else Console.WriteLine("There aren't enough numbers to fill the array");

*/

/*

// Задание 5. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] Create2dArray(int rows, int columns, int minValue)
{
    int[,] array = new int[rows, columns];
    int quantityOfNumbers = rows * columns;
    int numberOfCycles = 0;

    if(rows < columns) 
    {
        if(rows%2 == 0) numberOfCycles = rows / 2;
        else numberOfCycles = (rows + 1) / 2;
    }
    else 
    {
        if(columns%2 == 0) numberOfCycles = rows / 2;
        else numberOfCycles = (columns + 1) / 2;  
    } 

    for(int y = 0; y < numberOfCycles && quantityOfNumbers > 0; y++)
    { 
        int i = y;
        int j = y;

        for(j = y; j < columns-y && quantityOfNumbers > 0; j++)
        {
            array[i,j] = minValue + rows * columns - quantityOfNumbers;
            quantityOfNumbers--;
        }

        for(i = y+1; i < rows-y && quantityOfNumbers > 0; i++)
        {
            array[i,columns-y-1] = array[i-1,columns-y-1] + 1;
            quantityOfNumbers--;
        }

        for(j = columns-y-2; j > y-1 && quantityOfNumbers > 0; j--)
        {
            array[rows-y-1,j] = array[rows-y-1,j+1] + 1;
            quantityOfNumbers--;
        }

        for(i = rows -2-y; i>y && quantityOfNumbers > 0; i--)
        {
            array[i,y] = array[i+1,y] + 1;
            quantityOfNumbers--;
        }
    }
    return array;
    
}

void Show2dArray(int[,] array){
    for(int i = 0; i< array.GetLength(0); i++)
    {
        for(int j = 0; j< array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");}
    Console.WriteLine();
    }
}

Console.Write("Input a number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input mininmum of value: ");
int min = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2dArray(m,n,min);
Console.WriteLine();
Show2dArray(myArray);

*/