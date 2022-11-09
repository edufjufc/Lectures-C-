int CutNumber(int number)
{
    int ed=number%10;
    int sot=number/100;
    number=sot*10+ed;
    return number;
}

int num= new Random().Next(100, 1000);
int result=CutNumber(num);
Console.WriteLine($"New version of number {num} is {result}");

/*

// Задача 1 Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

int FindMaxNum(int n)
{
    int ed = n % 10;
    int dec = n / 10;
    if(ed > dec)
        return ed;
    else
        return dec;
}
int number = new Random().Next(10, 100);
int result = FindMaxNum(number);
Console.WriteLine($"from {number} {result} is bigger");

*/

/*

// Задача 2 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.

bool Div(int n1, int n2)
{
    if(n2 % n1 == 0) return true;
    else return false;
}

Console.WriteLine("Input first number");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int n2 = Convert.ToInt32(Console.ReadLine());
bool result = Div(n1, n2);
Console.WriteLine(result);

*/

/*

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool FindQuad(int n1, int n2)
{
    if(n1 * n1 == n2 || n2 *n2 == n1) return true;
    else return false;
}

Console.WriteLine("Input first number");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number");
int n2 = Convert.ToInt32(Console.ReadLine());
bool result = FindQuad(n1, n2);
Console.WriteLine(result);

*/