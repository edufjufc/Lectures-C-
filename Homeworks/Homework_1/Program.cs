/*

//Задание 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input a first number: ");
int n1=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int n2=Convert.ToInt32(Console.ReadLine());

if (n1>n2)
{
    Console.WriteLine($"Maximum is {n1} and minimum is {n2}");
}
else
{
    Console.WriteLine($"Maximum is {n2} and minimum is {n1}");
}

*/

/*

// Задание 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Input a first number: ");
int n1=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int n2=Convert.ToInt32(Console.ReadLine());

Console.Write("Input a third number: ");
int n3=Convert.ToInt32(Console.ReadLine());

int max = n1;

if (n2>max) max=n2;
if (n3>max) max=n3;

Console.WriteLine("Maximum is " + max);

*/

/*

//Задание 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number: ");
int num=Convert.ToInt32(Console.ReadLine());

if ((num%2)==0)
{
    Console.Write("Yes");
}
else
{
    Console.Write("No");
}

*/

/*

//Задание 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Input a number: ");
int num=Convert.ToInt32(Console.ReadLine());

int curret=1;

while (curret<=num)
{
    if ((curret%2)==0)
    {
        Console.Write(curret + " ");
    }
    curret+=1;
}

// Не рассматривала тот вариант, когда пользователь вводит отрицательное число, так как в задаче написано, что от 1 до N => N по формулировке не должно быть меньше 1.

*/