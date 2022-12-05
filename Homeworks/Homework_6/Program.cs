/*

// Задание 1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] CreateRandomArray(int size)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Please, enter number #{i+1} of array: ");
        array[i]=Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

int Count(int[] array)
{
   int res=0;
   for(int i = 0; i < array.Length; i++)
        if (array[i]>0) res++;
   return res;
}

Console.Write("Input a number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());

int[] myArray=CreateRandomArray(n);
int count=Count(myArray);
Console.WriteLine("The number of numbers greater than zero: "+ count);

*/

/*

// Задние 2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void FindCross(double k1, double b1, double k2, double b2)
{
    if (k1 != k2)
    {
        double xCross = (b2 - b1) / (k1 - k2);
        double yCross = k1 * xCross + b1;
        Console.WriteLine("(" + xCross + "; " + yCross + ")");
    }
    else 
        Console.Write("The lines don't intersect");
}

Console.Write("Enter k1 for first right line: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b1 for first right line: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter k2 for second right line: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter b2 for second right line: ");
double b2 = Convert.ToInt32(Console.ReadLine());
FindCross(k1, b1, k2, b2);

*/