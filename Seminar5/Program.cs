// Задача 1: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
/* int[] ChangNums(int[] array)
{
    for(int i=1;i<array.Length;i++){
        array[i] *=(-1);
        Console.Write(array[i]+" ");
    }
    return array;
        
}
*/

// Задача 2: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.

/*int[] array = { 3, 54, 76, 87, 98 };
void ChangNums(int[] array, int namber)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == namber)
        {
            Console.WriteLine("colth;bncz d vfccbdt");
            break;
        }
    }
}
Console.Write("input number: ");
int num = Convert.ToInt32(Console.ReadLine());
ChangNums(array, num);
*/
/* string FindNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return "yes";
        
        }       
    }
    return "no";
}
C
*/
// Задача 3: Задайте одномерный массив из 15 случайных чисел. 
// Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
/* int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int CountNumbers(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min && array[i] < max)
            count++;

    }
    return count;

}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

}

int FindNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= 10 && array[i] <= 99)
            count++;
    }
    return count;
}


int[] myArray = CreateRandomArray(15, -100, 100);
ShowArray(myArray);
Console.WriteLine(CountNumbers(myArray, 10, 99));
*/

// Задача 4 : Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
/* int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("1 element is: "+ array[i]);
                          
                          
              

    }
    Console.WriteLine();

}

int[] NewMagicArray(int[] array)
{
    int newSize = array.Length / 2;
    int[] newArray = new int[newSize];
    for (int i = 0, j = array.Length - 1; i < newSize; i++, j--)
    {
        newArray[i] = array[i] * array[j];
    }
    return newArray;
}
int[] arr = CreateRandomArray(9, 1, 10);
int[] newArr = NewMagicArray(arr);
ShowArray(newArr);
*/
