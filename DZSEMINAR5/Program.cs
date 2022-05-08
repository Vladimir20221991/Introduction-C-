//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*  Console.Clear();
Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Enter the degree: ");
int degree = Convert.ToInt32(Console.ReadLine());
int natural_degree = num;
for (int i = 1; i < degree; i++)
{ 
    natural_degree = natural_degree * num;
         
}
Console.WriteLine();
Console.WriteLine($"{num} ^ {degree} = {natural_degree}");
Console.WriteLine();
*/

//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
/*Console.Clear();
Console.WriteLine();
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = 0;
Console.Write($"Sum digits number {number} = ");

while (number > 0)
{
    int digit = number % 10;
    sumNumber = sumNumber + digit;
    number = number / 10;
}
Console.WriteLine(sumNumber);
Console.WriteLine();
*/

//Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
/*  Console.Clear();
Console.WriteLine();
int[] SetAnArray(int size)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
}

void ArrayOutput(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();

}

ArrayOutput(SetAnArray(8));
Console.WriteLine();
*/
