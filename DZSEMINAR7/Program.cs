// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

/*  Console.Clear(); Console.WriteLine();

void FillTwoDimensionalArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * 100;
        }
    }
}


void PrintRealNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F} ");  // Формат вывода чисела в консоль
                                                 // с фиксированной точкой символом F или f.       
        }
        Console.WriteLine();
    }
}
int string = 5;
int col = 4;
double[,] array = new double [string, col];

FillTwoDimensionalArray(array);
PrintRealNumbers(array);
*/

// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

/*  Console.Clear(); Console.WriteLine();
void FillTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 100);
        }
    }
}

void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,-3}", array[i, j]);
        }
        Console.WriteLine();
    }
}Console.WriteLine();

Console.Write("Введите размер 2D матрици (строка): ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер 2D масрици (столбец): ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[line, column];

Console.WriteLine();
FillTwoDimensionalArray(array);
PrintTwoDimensionalArray(array);
Console.WriteLine();

void ItemPositions(int[,] array)
{
    Console.Write("Введите строку:");
    int pos1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец:");
    int pos2 = Convert.ToInt32(Console.ReadLine());

    if (pos1 < 0 | pos1 > array.GetLength(0) | pos2 < 0 | pos2 > array.GetLength(1))
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
    }
}
ItemPositions(array);
*/

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*  Console.Clear(); Console.WriteLine();

void FillTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintTwoDimensionalArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(); 
    }
}

string ArithmeticMean(int[,] array)
{
    string result = string.Empty;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        int count = 0;
        double mean = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            count++;
        }
        mean = sum / count;
        result += mean.ToString() + "; ";
        
    }
    return result;
    
}

int s = 5;
int c = 5;
int[,] myarray = new int[s, c];
FillTwoDimensionalArray(myarray);
PrintTwoDimensionalArray(myarray);
Console.WriteLine();
Console.Write($"Среднее арифметическое каждого столбца: {ArithmeticMean(myarray)}");        
Console.WriteLine();Console.WriteLine();
*/



