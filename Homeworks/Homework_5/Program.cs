/*

// Задание 1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
        array[i]=new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");

    Console.WriteLine();
}

int CountEvenNumbers(int[] array)
{
    int count=0;

    for(int i=0; i<array.Length; i++)
        if(array[i]%2==0) count++;
    
    return count;
}

Console.Write("Input a number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

int[] myArray=CreateRandomArray(n,min,max);
ShowArray(myArray);

int count= CountEvenNumbers(myArray);
Console.WriteLine("Count of even numbers: "+ count);

*/

/*

// Задание 2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
        array[i]=new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");

    Console.WriteLine();
}

int SumOddPositions(int[] array)
{
    int sum=0;

    for(int i=1; i<array.Length; i+=2)
        sum+=array[i];
    
    return sum;
}

Console.Write("Input a number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

int[] myArray=CreateRandomArray(n,min,max);
ShowArray(myArray);

int sum= SumOddPositions(myArray);
Console.WriteLine("Sum of elements in odd positions: "+ sum);

*/

/*

// Задание 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double [size];

    for(int i = 0; i < size; i++)
        array[i]=Math.Round((new Random().Next(minValue, maxValue+1) + new Random().NextDouble()),2);

    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");

    Console.WriteLine();
}

double DifferenceMinMax(double[] array)
{
    double min=array[0];
    double max=array[0];

    for(int i=1; i < array.Length; i++)
    {
        if (array[i]<min) min=array[i];
        if (array[i]>max) max=array[i];
    }
    
    double dif=max-min;
    return dif;
}

Console.Write("Input a number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

double[] myArray=CreateRandomArray(n,min,max);
ShowArray(myArray);

double dif= DifferenceMinMax(myArray);
Console.WriteLine("The difference between the maximum and minimum elements: "+ dif);

*/