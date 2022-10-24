// Вывод строк
// int a= -25;
// Console.WriteLine("My number is " + a + " and it is good!");
// Console.WriteLine($"My number is {a} and it is good!");


//Ввод числа от пользователя
// Console.Write("Input a number: ");
// int num=Convert.ToInt32(Console.ReadLine());
// num = num*2;
// Console.WriteLine("Your new number is " + num);


// Пример оформления дз

// ДЗ 1
/*
// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.Write("Input a first number: ");
int n1=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2=Convert.ToInt32(Console.ReadLine());

int quad2=n2*n2;
if (n1==quad2)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

/*
//Задача 2.Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input a positiv integer number: ");
int n=Convert.ToInt32(Console.ReadLine());

int curret = -n;

while(curret<=n)
{
    Console.Write(curret + " ");
    curret++;
}
*/

//Задача 3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Input a three-digit number: ");
int num=Convert.ToInt32(Console.ReadLine());

int result= num % 10;
Console.Write($"Lust digit of {num} is {result}");
