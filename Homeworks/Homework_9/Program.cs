/*

// Задание 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void ShowNumbers(int n)
{
    Console.Write(n+" "); 
    if(n>1) ShowNumbers(n-1);
}

Console.Write("Input a number: ");
int num=Convert.ToInt32(Console.ReadLine());

ShowNumbers(num);

*/

/*

// Задание 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ShowSumm(int m, int n)
{
   if(m != n+1) return ShowSumm(m+1, n)+m; // n+1 т.к. без этого программа не берёт в сумму число n
   return 0;
}


Console.Write("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(m<n) Console.WriteLine(ShowSumm(m,n));
if(m>n) Console.WriteLine(ShowSumm(n,m));

*/

/*

// Задание 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if(m == 0) return n +1;
    if(m > 0 && n == 0) return Akkerman(m-1, 1);
    if(m > 0 && n > 0) return Akkerman(m-1, Akkerman(m, n-1));
    return 0;
}


Console.Write("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Akkerman(m, n));

*/

