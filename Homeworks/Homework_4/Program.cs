/*

// Задание 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int degree(int a, int b)
{
    int st=1;
    for(int count=1;count<=b;count++) st*=a;
    return st;
}

Console.Write("Input first number: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int b=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The number {a} to the power of {b} is {degree(a, b)}");

*/

/*

// Задание 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int FindSum(int num)
{
    int sum=0;
    while (num>0)
    {
        sum+=num%10;
        num/=10;
    }
    return sum;
}

Console.Write("Input a number: ");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of the digits in the number {a} is {FindSum(a)}");

*/

/*

// Задание 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int lenght=collection.Length;
    int index=0;
    while(index<lenght)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count=col.Length;
    int position=0;
    while(position<count)
    {
        Console.Write(col[position]+" ");
        position++;
    }

}

int[] array=new int[8];
FillArray(array);
PrintArray(array);

*/