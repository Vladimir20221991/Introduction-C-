// Задача 1:
/* bool IsTriangleExist(int a, int b, int c)
{
    if (a < b + c && b < a + c && c < a + b)
    {
        return true;
    }
    return false;
}
if (IsTriangleExist(1, 7, 8))
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
*/

// Задача 2: Написать программу которая принимает на вход однородный массив, и возвращает его перевернутую версию.
/*  int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}

int[] SelectionSort(int[] array)
{
    int newSize = array.Length;
    int[] newArray = new int[newSize];
    for (int i = 0, j = array.Length - 1; i < newSize; i++, j--)
    {
        newArray[i] = array[j];
        
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}
int[] array = CreateRandomArray(5, 1, 10);
int[] newArray = SelectionSort(array);
ShowArray(newArray);

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
    return array;
}


void ReverseArray(int[] b)
{
    int temp;

    for (int i = 0, j = b.Length - 1; i < b.Length; i++, j--)
    {
        temp = b[j];
        Console.Write(temp + " ");
    }
}
int[] array = CreateRandomArray(6, 1, 10);
ReverseArray(array);
*/


// Задача 3: Реализовать метод который принимает положительное число и возвращает количество цифр фибоначи.
/*  Console.Clear();
Console.WriteLine();
Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write(Num + " -> ");

void MetodFibonacci()
{
    int fibonacci0 = 0;
    int fibonacci1 = 1;
    int fibonacciSum = 0;
    Console.Write(fibonacci0 + " " + fibonacci1 + " ");
    for (int i = 2; i <= Num; i++)
    {
        fibonacciSum = fibonacci0 + fibonacci1;
        fibonacci0 = fibonacci1;
        fibonacci1 = fibonacciSum;
        Console.Write(fibonacciSum + " ");
    }
    
    
}

MetodFibonacci();
Console.WriteLine();
Console.WriteLine();
*/
