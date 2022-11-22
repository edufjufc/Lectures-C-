int FindSum(int number)
{
    int sum=0;

    for(int curret=1; curret<=number; curret++) sum+=curret;

    return sum;
}

Console.Write("Input a number: ");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of number between 1 and {a} is {FindSum(a)}");