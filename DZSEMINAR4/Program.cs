// Задача 1:Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// Например: [345, 897, 568, 234] -> 2
/*
Console.Clear();
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
    return array;
}
void NumberOfEvenNumbers(int[] array)
{
    int positive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            positive++;
        Console.Write(array[i] + " ");

    }
    Console.Write("-> " + positive + " Четных чисел.");
}
Console.WriteLine();
NumberOfEvenNumbers(CreateArray(10));
Console.ReadLine();
*/

//Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
/*
Console.Clear();
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        
        array[i] = new Random().Next(-100,100);
    }
    return array;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
void SumOfOddPositions(int[] array)
{
    int sum = 0;
    
    for (int i = 0; i < array.Length ; i++)
    {
        if (i % 2 > 0) 
            sum += array[i];
    }
    Console.Write("-> " + sum + " Сумма элементов на нечётных позициях.");
}


int[] myArray = CreateArray(10);
ShowArray(myArray);
SumOfOddPositions(myArray);
Console.ReadLine();
*/

// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
/*
Console.Clear();
double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

void FindSumOfElements(double[] array)
{
    double difference = array.Max() - array.Min();
    Console.WriteLine($"Минимальное значение массива {array.Min()}, максимальное значение массива {array.Max()}.");
    Console.WriteLine($"Разница {difference} между максимальным и минимальным");
}


double[] myArray = CreateRandomArray(5);
ShowArray(myArray);
FindSumOfElements(myArray);
*/
