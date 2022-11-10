
// 1 задание. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

bool palin(int n)
{
    if(n%10==n/10000 && n%100/10==n/1000%10) return true;
    else return false;
}

Console.Write("Input a number: ");
int num=Convert.ToInt32(Console.ReadLine());
bool result=palin(num);
if(result==true) Console.WriteLine($"Number {num} is palindrome");
else Console.WriteLine($"Number {num} is't palindrome");

/*

// 2 задание. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Theorem(double numX1, double numY1, double numZ1, double numX2, double numY2, double numZ2)
{
    double RollsFirst=numX1-numX2;
    double RollsSecond=numY1-numY2;
    double RollsFird=numZ1-numZ2;
    double Hypotenus=RollsFirst*RollsFirst+RollsSecond*RollsSecond+RollsFird*RollsFird;
    Hypotenus=Math.Sqrt(Hypotenus);
    return Hypotenus;
}

Console.WriteLine("Input coordinates of the first point:");
int x1=Convert.ToInt32(Console.ReadLine());
int y1=Convert.ToInt32(Console.ReadLine());
int z1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input coordinates of the second point:");
int x2=Convert.ToInt32(Console.ReadLine());
int y2=Convert.ToInt32(Console.ReadLine());
int z2=Convert.ToInt32(Console.ReadLine());
double result=Theorem(x1, y1, z1, x2, y2, z2);
Console.WriteLine("Distance between points " + Math.Round(result, 2));

*/

/*

// 3 задание. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int n)
{
    int count=1;
    while(count<=n)
    {
        Console.Write(count*count*count+" ");
        count++;
    }
}

Console.WriteLine("Input a number:");
int num=Convert.ToInt32(Console.ReadLine());
Cube(num);

*/