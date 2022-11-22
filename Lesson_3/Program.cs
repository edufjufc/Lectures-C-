/*
void ShowRange(int quart)
{
    if(quart==1) 
        Console.WriteLine("x > 0 and y > 0");
    else if(quart==2) 
        Console.WriteLine("x < 0 and y > 0");
    else if(quart==3) 
        Console.WriteLine("x < 0 and y < 0");
    else if(quart==1) 
        Console.WriteLine("x > 0 and y < 0");
    else
        Console.WriteLine("Wrong number!");
}

Console.Write("Input a number of quart: ");
int quartNum=Convert.ToInt32(Console.ReadLine());

ShowRange(quartNum);

*/

/*

//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int ShowQuart(int numX, int numY)
{
    int cuart = 0;
    if(numX > 0 && numY > 0) cuart = 1;
    else if(numX < 0 && numY > 0) cuart = 2;
    else if(numX < 0 && numY < 0 ) cuart = 3;
    else if(numX > 0 && numY < 0) cuart = 4;
    return cuart;

}

Console.Write("Input x ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y ");
int y = Convert.ToInt32(Console.ReadLine());
int resualt = ShowQuart(x, y);

if(resualt == 0) Console.Write("Wrong number");
else Console.WriteLine($"Number of quart {resualt}" );

*/

/*

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double Theorem(double numX1, double numY1, double numX2, double numY2)
{
    double RollsFirst = numX1 - numX2;
    RollsFirst = Math.Pow(RollsFirst, 2);
    double RollsSecond = numY1 - numY2;
    RollsSecond = Math.Pow(RollsSecond, 2);
    double Hypotenus = RollsFirst + RollsSecond;
    Hypotenus = Math.Sqrt(Hypotenus);
    return Hypotenus;
}

Console.Write("Input x1 ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1 ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2 ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2 ");
double y2 = Convert.ToInt32(Console.ReadLine());

double resualt = Theorem(x1, y1, x2, y2);
Console.WriteLine("Distance between points " + Math.Round(resualt, 2));

*/

//Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.

void Cube(int n)
{
    int count=1;
    while(count<=n)
    {
        Console.Write(count*count+" ");
        count++;
    }
}

Console.WriteLine("Input a number:");
int num=Convert.ToInt32(Console.ReadLine());
Cube(num);