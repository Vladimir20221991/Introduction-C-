// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

/*  Console.Clear(); Console.WriteLine();
int[,] CreateArray(int size, int size2)
{
    int[,] array = new int[size,size2];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Ordering(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = j+1; k < matr.GetLength(1); k++)
            {
                if (matr[i, j] > matr[i, k ])
                {
                    int t = matr[i, j];
                    matr[i, j] = matr[i, k];
                    matr[i, k ] = t;
                }
            }
        }
    }
}

int [,] array= CreateArray(5,5);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Ordering(array);
Console.WriteLine("Сортировка по строкам:");
PrintArray(array);
*/

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*  Console.Clear(); Console.WriteLine();
int[,] CreateArray(int size, int size2)
{
    int[,] array = new int[size,size2];

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
        
    }
    return array;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int MinSumString(int[,] matr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0) 
            {
                sum += matr[i, j];
                minSum += matr[i, j]; 
            }
            else sum += matr[i, j]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = i;
        }
        sum = 0;
    }
    return minNum;
}
int[,] myArray = CreateArray(5,5);
PrintArray(myArray);
Console.Write($"The smallest sum of elements in: {MinSumString(myArray)} Line");
*/

// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

/* Console.Clear(); Console.WriteLine();
void GetSpire(int[,] array)
{

    //С помощью переменной s задаются числа внутри массива начиная с 1.
    int s = 1;

    //Заполняем периметр массива по часовой стрелке.
    for (int i = 0; i < array.GetLength(1); i++)
    {
        array[0, i] = s;
        s++;
    }
    for (int j = 1; j < array.GetLength(0); j++)
    {
        array[j, array.GetLength(1) - 1] = s;
        s++;
    }
    for (int y = array.GetLength(1) - 2; y >= 0; y--)
    {
        array[array.GetLength(0) - 1, y] = s;
        s++;
    }
    for (int x = array.GetLength(0) - 2; x > 0; x--)
    {
        array[x, 0] = s;
        s++;
    }

    //Периметр заполнен. Продолжаем заполнять массив и задаём
    //координаты ячейки, которую необходимо заполнить следующей.
    int c = 1;
    int d = 1;

    while (s < array.GetLength(0) * array.GetLength(1))
    {
        //Движемся вправо.
        while (array[c, d + 1] == 0)
        {
            array[c, d] = s;
            s++;
            d++;
        }

        //Движемся вниз.
        while (array[c + 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c++;
        }

        //Движемся влево.
        while (array[c, d - 1] == 0)
        {
            array[c, d] = s;
            s++;
            d--;
        }

        //Движемся вверх.
        while (array[c - 1, d] == 0)
        {
            array[c, d] = s;
            s++;
            c--;
        }
    }

    //При данном решении в центре всегда остаётся незаполненная ячейка.
    //Убираем её при помощи следующего цикла.
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            if (array[x, y] == 0)
            {
                array[x, y] = s;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                
                Console.Write(array[i, j] + ",  ");
            }
            else
            {
                Console.Write(array[i, j] + ", ");
            }
        }
        Console.WriteLine();
    }

}
int[,] myArray = new int[6, 7];
GetSpire(myArray);
Console.WriteLine();
*/
