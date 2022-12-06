

// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int [size];

    for(int i = 0; i < size; i++)
        array[i]=new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i]+" ");

    Console.WriteLine();
}

void ReversArray(int[] array)
{
    /*
    for (int i = 0, j=array.Length-1; i < j; i++, j--)
    {
        int temp=array[i];
        array[i]=array[j];
        array[j]=temp;
    }
    */
    
    /* for (int i = 0; i < array.Length/2; i++)
    {
        int temp=array[i];
        array[i]=array[array.Length-1-i];
        array[array.Length-1-i]=temp;
    }

}

Console.Write("Input a number of elements: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min=Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max=Convert.ToInt32(Console.ReadLine());

int[] myArray=CreateRandomArray(n,min,max);
ShowArray(myArray);
ReversArray(myArray);
ShowArray(myArray);

*/

/*

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

bool Triangle(int a, int b, int c)
{
    if((a + b > c) && (a + c > b) && (c + b > a)) 
    return true;
    else return false;
}

Console.WriteLine("Enter first length:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second length:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third length:");
int c = Convert.ToInt32(Console.ReadLine());
bool res = Triangle(a, b, c);
Console.WriteLine(res);

*/

/*

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.

int[] Fib( int n, int a, int b)
{
    int[] array = new int[n];
    array[0] = a;
    array[1] = b;
    for(int i = 2; i < n; i++)
        array[i] = array[i-1] + array[i-2];
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}

Console.WriteLine("Enter a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N:");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = Fib(n, a, b);
ShowArray(myArray);

*/

/*

// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue+1);
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine(" ");
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for(int i = 0; i< array.Length; i++)
        newArray[i] = array[i];

return newArray;
}

Console.WriteLine("Enter size of array:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter max of array:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter min of array:");
int min = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(n, min, max);
ShowArray(myArray);
int[] array2 = CopyArray(myArray);
ShowArray(array2);

*/