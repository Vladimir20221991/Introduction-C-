// Задача 1: Нахождение суммы от 1 до введенного числа.
/*
int NaturalSum(int a)
{
    int sum = 0;
    if (a < 1) return 0;
    else
    {
        for (int i = 1; i <= a; i++)
        {
            sum = sum + i;
            //sum+=; строка выполняет то же, что и стр.10
        }
        return sum;
    }
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum of elements is " + NaturalSum(num));
*/

// Задача 2: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int NumberOfDigits(int number)
{
    int a = 0;
    while (number > 0)
    {
        number = number / 10;
        a++;
    }
    return a;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of digits in a number " + NumberOfDigits(num));
*/

/*
// Задача 3: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int TheProductOfNumbers(int a)
{
    int composition = 1;
    if (a < 1) return 0;
    else
    {
        for (int i = 1; i <= a; i++)
        {
            composition = composition * i;
        }
        return composition;
    }
}


Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The product of numbers from 1 to N is = " + TheProductOfNumbers(num));
*/


// Задача 4: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]

/*
int[] PrintArray(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        arr[i]= new Random().Next(0,2);
        Console.Write(arr[i]+" ");
        
    }
    return arr;
}
int[] array = new int[8];
PrintArray(array);
*/


//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.


int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write("input " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

void FindSumOfElements(int[] array)  // 1 -4 3 -2 6 -1 5 3 8 -5
{
    int plusSum = 0;
    int minusSum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > 0)
            plusSum += array[i];
        else
            minusSum += array[i];
    }
    Console.WriteLine("Sum of positive element is " + plusSum);
    Console.WriteLine("Sum of negative element is " + minusSum);

}

int[] myArray = CreateArray(12);
ShowArray(myArray);
FindSumOfElements(myArray);