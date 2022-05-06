//Поиск четверти по координатам.
/*
int FindQvart(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    else if (x < 0 && y > 0)
        return 2;
    else if (x < 0 && y < 0)
        return 3;
    else if (x > 0 && y < 0)
        return 4;
    else
        return 0;

}

Console.Write("Input X coordinate: ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate: ");
int yDot = Convert.ToInt32(Console.ReadLine());

int qvartNum = FindQvart(xDot,yDot);

if (qvartNum == 0)
    Console.WriteLine("Dot located on the axes!");
else
    Console.WriteLine("Number of quart is " + qvartNum);
*/
//Задача 2: Напишите программу, которая по номеру четверти,
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void FindQvart(int q)
{
    if (q == 1)
        Console.WriteLine(" х > 0 и y > 0 ");
    else if (q == 2)
        Console.WriteLine(" х < 0 и y > 0 ");
    else if (q == 3)
        Console.WriteLine(" х < 0 и y < 0 ");
    else if (q == 4)
        Console.WriteLine(" х > 0 и y < 0 ");
    else 
        Console.WriteLine("incorrect number!");
}

Console.Write("Input number of qvart from 0 to 4: ");
int Qvartnum = Convert.ToInt32(Console.ReadLine());

FindQvart(Qvartnum);
*/

//Расстояние (Хв - Ха)  (Ув - Хв)
// АВ = (Хв - Ха)2 * (Ув - Уа)2 = квадратный корень из выражения.

//Console.Write(Math.Sqrt(25));

//double xA, yA, xB, yB;
/*
double Space2d(double x1, int y1,int x2, int y2)
{
    return Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
}

Console.Write("Введите координату х первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату x второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Space2d(x1,y1,x2,y2));

*/
/*
void TableOfSquares(int N)
{
    int count = 1;
    Console.Write(N + " -> ");
    while(count <= N)
    {
        Console.Write(count*count + " ");
        count++;
    }
}
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0)
    TableOfSquares(num);
else
    Console.WriteLine("Введите положительное число");
*/