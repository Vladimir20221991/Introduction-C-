// Задача 1. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

/* Console.Clear(); void ShowNumber()
{
    
    int firstNum = num / 10;
    int secondNum = num % 10;

    Console.Write(num + " -> ");

    if (firstNum > secondNum)
    {
        Console.WriteLine(firstNum);
    }
    else
    {
        Console.WriteLine(secondNum);
    }
}
ShowNumber();
*/

/* Console.Clear(); int ShowNumber()
{
    int num = new Random().Next(10, 99);
    int firstNum = num / 10;
    int secondNum = num % 10;

    Console.Write(num + " -> ");

    if (firstNum > secondNum)
    {
        return firstNum;
    }
    else
    {
        return secondNum;
    }
}

int a = ShowNumber();
Console.WriteLine(a);
*/

/* Console.Clear(); int ShowNumber(int n)
{
    int firstNum = n / 10;
    int secondNum = n % 10;

    Console.Write(n + " -> ");

    if (firstNum > secondNum)
    {
        return firstNum;
    }
    else
    {
        return secondNum;
    }
}


int a = ShowNumber(num);
Console.WriteLine(a);
*/


// Задача 2: Напишите программу, которая выводит
// случайное трёхзначное число и удаляет вторую цифру
// этого числа. 456 -> 46; 782 -> 72; 918 -> 98

/* void DeletesADigit()
{
    int num = new Random().Next(100, 1000);
    int numberTwo = num % 10;
    int numberOne = num / 100;
    Console.Write($"{num} -> {numberOne * 10 + numberTwo}");
    
}
DeletesADigit();
*/

// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.


/* void multiplicity()
{
    Console.Write("input 1 number: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.Write("input 2 number: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    if (num % num2 == 0)
        Console.Write(num + " Кратно " + num2);
    else
        Console.Write(num + " НЕ кратно " + num2);
}
multiplicity();
*/


//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.[1,0,1,1,0,1,0,0]
