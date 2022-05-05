//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]
/*
Console.Write("Введите число:   ");
string writeN = Console.ReadLine();
int N = Convert.ToInt32(writeN);

int GetNumbersComposition(int x)
{
    int comp = 1;
    for (int num = 1; num <= x; num++)
    {
        comp = comp * num;
    }
    return comp;
}

Console.WriteLine($"Произведение чисел от 1 до {N} равно {GetNumbersComposition(N)}");
Console.WriteLine();





/*
int N = 8;
int min = 0;
int max = 1;

int[] CreateArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < N; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
/*
PrintArray(CreateArray(N, min, max));
//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

//Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

/*

int size = new Random().Next(10, 26);
int min = 1;
int max = 100;
Console.WriteLine($"Количество элементов массива: {size}");

int[] FillArray( size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// первый вариант - собираем новый массив из произведений пар.
// В случае, если количество элементов исходного массива нечетное, среднее значение массива "выпадает" из обработки

int[] GetPairProduct(int[] data)
{
    int[] product = new int[data.Length / 2];
    int last = data.Length - 1;
    for (int i = 0; i < data.Length / 2; i++)
    {
        product[i] = data[i] * data[last];
        last = last - 1;
    }
    return product;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] array = FillArray(size, min, max);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Первый вариант:");
PrintArray(GetPairProduct(array));

// воторой вариант с выводом среднего числа (если количество элементов массива нечетное)

void PrintProductPairs(int[] dataArray)
{
    int last = dataArray.Length - 1;
    for (int i = 0; i < dataArray.Length / 2; i++)
    {
        Console.WriteLine($"{dataArray[i]} x {dataArray[last]} = {dataArray[i] * dataArray[last]} ");
        last--;
    }
    if (dataArray.Length % 2 > 0) System.Console.WriteLine($"Число {dataArray[dataArray.Length / 2]} не имеет пары");
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Второй вариант:");
PrintProductPairs(array);
*/
/*
int[] CreateArray(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] ReversArray(int[] arr)
{
    int temp;
    for(int i = 0, j = arr.Length -1; i < arr.Length / 2; i++, j--)
    {
        temp = arr[i];
        arr[i] = arr[j];
        arr[i] = temp;
    }
    return arr;
}

int[] myArr = CreateArray(10);
PrintArray(myArr);
ReversArray(myArr);
PrintArray(myArr);
*/
/*

void Fibonach(int n)
{
    int n1 = 1;
    int n2 = 1;
    int count = 3;
    while (count < n)


}


int[] Fibonach(int n)
{
    int[] Arrey =
}
*/

