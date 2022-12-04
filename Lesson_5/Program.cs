/*

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных элементов.

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

int FindNegativeSum(int[] array)
{
    int sum=0;

    for(int i=0; i<array.Length; i++)
        if(array[i]<0) sum+=array[i];
    
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

int negativeSum= FindNegativeSum(myArray);
Console.WriteLine("Sum of negative elements: "+ negativeSum);

*/



//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.




//Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].
 
//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.