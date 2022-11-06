/*

// Задание 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber(int number)
{
    int second=number%100/10;
    return second;
}

Console.Write("Input a number: ");
int num=Convert.ToInt32(Console.ReadLine());
int result=CutNumber(num);
Console.WriteLine($"The second digit of the number {num} is {result}");

*/

/*

// Задание 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int CutNumber(int number)
{
    int second=number/100;
    if (second==0)
    {
        return -1;
    }
    else
    {
        while(number>999)
        {
            number=number/10;
        }
        return number%10;
    }
}

Console.Write("Input a number: ");
int num=Convert.ToInt32(Console.ReadLine());
int result=CutNumber(num);
if(result==-1)
{
    Console.WriteLine("A number less than three digits");
}
else
{
    Console.WriteLine($"The third digit of the number {num} is {result}");
}

*/

/*

// Задание 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool CutNumber(int number)
{
    if(number==6 || number==7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Input a number: ");
int num=Convert.ToInt32(Console.ReadLine());
bool result=CutNumber(num);

if(result==true)
{
    Console.WriteLine($"Day number {num} is a day off");
}
else
{
    Console.WriteLine($"Day number {num} is not a day off");
}

*/
