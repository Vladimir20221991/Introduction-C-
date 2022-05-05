//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
void showsTheSecondDigit()
{
    int num = new Random().Next(100, 1000); 
    int second = num /10 % 10;
    Console.Write(num + " -> ");
    Console.WriteLine(second);    
}
showsTheSecondDigit();
*/

//Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.Write(Num + " -> ");

int TheThirdDigitOutOfThree()
{
    
    if (Num > 1000 && Num < 10000) 
    {
        int fourDigit = Num / 10;
        return fourDigit;

    }
    else if(Num > 10000 && Num < 100000)
    {
        int fiveDigit = Num / 100;
        return fiveDigit;
    }
    else if(Num > 100000 && Num < 1000000)
    {
        int sixDigit = Num / 1000;
        return sixDigit;
    }
    else if(Num > 1000000)
    {
        int sevenDigit = Num / 10000;
        return sevenDigit;
    }
    return Num;
}
int remains =TheThirdDigitOutOfThree();
if (Num < 100)
{
    Console.Write("У числа нет третьей цифры");
}
else
{
    int a = remains % 10;
    Console.WriteLine(" The third number -> " + a);
}

*/

// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*  
void weekday()
{
    Console.WriteLine();
    Console.Write("Введите день недели от 1 до 7: ");
    int num = Convert.ToInt32(Console.ReadLine());

    if(num == -1 || num > 7)
    {
        Console.WriteLine();
        Console.Write (" Введите значение от 1 до 7!");
    }
    if(num >= 1 && num <= 5)
    {
        Console.WriteLine();
        Console.Write(num + " NO Рабочий день");
    }
    else
    {
        Console.WriteLine();
        Console.Write(num + " YES Ура это выходной");
    }
   
}    
weekday();*/
