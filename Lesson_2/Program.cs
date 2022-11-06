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