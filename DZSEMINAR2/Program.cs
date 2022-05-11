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
/*  Console.Clear();
Console.Write("Введите число: ");
int Num = Convert.ToInt32(Console.ReadLine()); Console.WriteLine();
Console.Write(Num + " -> ");

void TheThirdDigitOutOfThree()
{
    while (Num > 1000)
    {
        Num = Num / 10;
    }
    if (Num > 99)
        Console.Write(Num % 10 + " - третья цифра в числе.");
    else
        Console.Write("У числа нет третьей цифры");
}

TheThirdDigitOutOfThree();
Console.WriteLine(); Console.WriteLine();
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
