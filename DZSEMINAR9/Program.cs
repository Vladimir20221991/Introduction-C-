// Задача 1: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*  Console.Clear();
int Sum(int m, int n)
{
    if (n == m) return n;
    return m + Sum(m + 1, n);
    
}
Console.WriteLine();
Console.WriteLine(Sum(1, 15));
Console.WriteLine();
*/

// Задача 2: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
/*Console.Clear();
int SumDigits(int number)
{
    if (number < 1) return 0;
    return SumDigits(number / 10) + number % 10;
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Sum digits: {SumDigits(number)}");
Console.WriteLine();
*/
