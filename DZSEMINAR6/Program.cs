// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223-> 3

/*  Console.Clear();
Console.WriteLine();
Console.Write("Введите колличество чисел: ");
double n = Convert.ToDouble(Console.ReadLine());
double count = 0;
for (double i = 0; i < n; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    double x = Convert.ToDouble(Console.ReadLine());
    if (x > 0)
        count++;
}
Console.WriteLine($"Положительных чисел: {count}");
*/

//Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101; 3 -> 11; 2 -> 10.

/* void DecimalNumberConversion()
{
    Console.Clear();
    Console.WriteLine();
    Console.Write("Input decimal number: ");
    double num10 = Convert.ToDouble(Console.ReadLine()); // число в десятичной системе исчисления
    double a = 0; // a - остаток после % деления из которого формируется число в двоичной системе исчисления          
    double i = 0;
    double[] b = new double[12]; // массив с помощью которого запись двоичного числа будет выполнено вправильном направлении.                    

    while (num10 >= 1)
    {
        a = num10 % 2;
        b[i] = a;
        i++;
        num10 = num10 / 2;
    }
    Console.WriteLine();
    for (i = (b.Length - 1); i >= 0; i--)
    {
        Console.Write(b[i]);
    }

    
}
DecimalNumberConversion();
Console.WriteLine();
Console.WriteLine();
*/

// Задача 3: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
/* Console.Clear();
Console.Write("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();

double x = (b2 - b1)/(k1-k2);
double y = k1 * x + b1;
 
Console.WriteLine($"Пересечение в точке -> ({y};{x})");
Console.WriteLine();
*/