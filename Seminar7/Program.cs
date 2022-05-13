// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2;  1, -7, 567, 89, 223-> 3;

/* Console.Write("Введите число: ");
int kol = Convert.ToInt32(Console.ReadLine());

int count=0;
int num;
for (int i = 0; i < kol; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    if (num>0)count++;
}
Console.WriteLine(count);
*/

// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101; 3 -> 11;2 -> 10

/*  void DecimalNumberConversion()
{
    Console.Clear();
    Console.WriteLine();
    Console.Write("Input decimal number: ");
    int num10 = Convert.ToInt32(Console.ReadLine()); // число в десятичной системе исчисления          
    string i = string.Empty;

    while (num10 > 0)
    {
        i = (num10 % 2)+i;
        num10 /= 2;
    }
    Console.Write(i);
}
DecimalNumberConversion();
Console.WriteLine();
Console.WriteLine();
*/

// Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: 
// Aₘₙ = m+n. Выведите полученный массив на экран.

/* void PrintArray(int[,] imege)
{
    for (int i = 0; i < imege.GetLength(0); i++)
    {
        for (int j = 0; j < imege.GetLength(1); j++)
        {
            Console.Write($"{imege[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray(int[,] imegex)
{
    for (int i = 0; i < imegex.GetLength(0); i++)
    {
        for (int j = 0; j < imegex.GetLength(1); j++)
        {
            imegex[i,j] = i + j;
        }
    }
}
int [,] array= new int[5,5];
PrintArray(array);
FillArray(array);
PrintArray(array);
*/

// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

/*  void PrintArray(int[,] imege)
{
    for (int i = 0; i < imege.GetLength(0); i++)
    {
        for (int j = 0; j < imege.GetLength(1); j++)
        {
            Console.Write($"{imege[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FillArray2(int[,] imegex)
{
    for (int i = 0; i < imegex.GetLength(0); i+=2)
    {
        for (int j = 0; j < imegex.GetLength(1); j+=2)
        {
            
            imegex[i,j] *= imegex[i,j] ;
             
        }
        
    }
}

void FillArray(int[,] imege1)
{
    for (int i = 0; i < imege1.GetLength(0); i++)
    {
        for (int j = 0; j < imege1.GetLength(1); j++)
        {
            imege1[i, j] = new Random().Next(1, 10);
        }
    }
}

int [,] array= new int[4,4];
FillArray(array);
PrintArray(array);
FillArray2(array);
PrintArray(array);
*/

// Задайте двумерный массив. 
// Найдите сумму элементов, 
// находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.

/* int SumOfDiagonal(int[,] quad)
{
    int sum = 0;

    for (int i = 0; i < quad.GetLength(0); i++)
    {
        sum += quad[i,i];
    }
    return sum;
}

Console.Write("input size of matrix: ");
int size = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int[size,size];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,10);
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}
Console.WriteLine(SumOfDiagonal(matrix));
*/

