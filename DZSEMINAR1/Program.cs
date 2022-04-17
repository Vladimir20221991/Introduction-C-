// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input first integer number,Введите первое целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second integer number,Введите второе целое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)

{
    Console.Write("Max = ");Console.Write(num1);Console.Write(" > ");Console.Write("Min = ");Console.Write(num2);
}
else
{
    Console.Write("Min = ");Console.Write(num1);Console.Write(" < ");Console.Write("Max = ");Console.Write(num2);
}
// Задача 2: