// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// Например: 14212 -> нет; 12821 -> да; 23432 -> да

/*
int Palindrome()
{
    Console.Write("Введите целое число: ");
    int a =Convert.ToInt32(Console.ReadLine());     
     
    int temp = a;   
 
    int b = 0;      
 
    while (temp != 0)
    {
        b = b * 10 + temp % 10; 
        temp /= 10; 
    }
 
    if (a == b)
        Console.Write(a + " -> Да");
    else
        Console.Write(a + " -> Нет");
    
    return 0;
}

Palindrome();
*/

/*
// Задача 2:Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
// Например: A (3,6,8); B (2,1,-7), -> 15.84;    A (7,-5, 0); B (1,-1,9) -> 11.53;  

double Read3DPoint(double x1,double  y1,double z1,double x2,double y2,double z2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2 - z1)*(z2-z1));
}

Console.Write("Введите координату х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Read3DPoint(x1,y1,z1,x2,y2,z2));
/*

//Задача 3: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//Например: 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125

/*
Console.Write("Введите число: ");
int writeN = Convert.ToInt32(Console.ReadLine());
int N = writeN;

int[] GetCubeTable(int N)
{
    int[] cubs = new int[N];
    int number = 1;
    for (int i = 0; i < N; i++)
    {
        cubs[i] = number * number * number;
        number++;
    }
    return cubs;
}

void PrintTableCubs(int[] array)
{
    int number = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
        number++;
    }
}

int[] CubeTable = GetCubeTable(N);
PrintTableCubs(CubeTable);
*/

//Способ 2:

/*
void TableOfСubes(int N)
{
    int count = 1;
    Console.Write(N + " -> ");
    while(count <= N)
    {
        Console.Write(count*count*count + " ");
        count++;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
TableOfСubes(num);
*/
