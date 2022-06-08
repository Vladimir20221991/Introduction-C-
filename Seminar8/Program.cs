// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
/*
Console.WriteLine("Hello, World!");

void PrintArray(int[,] imege)
{
    for (int i = 0; i < imege.GetLength(0); i++)
    {
        for (int j = 0; j < imege.GetLength(1); j++)
        {
            Console.Write($"{imege[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void FillArray(int[,] imegex)
{
    for (int i = 0; i < imegex.GetLength(0); i++)
    {
        for (int j = 0; j < imegex.GetLength(1); j++)
        {
            imegex[i,j] =  + ;
        }
    }
}
int [,] array= new int[5,5];
PrintArray(array);
FillArray(array);
PrintArray(array);
*/

/*void Main()
{
    Console.Write("Введите строку:");
    int pos1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите столбец:");
    int pos2 = Convert.ToInt32(Console.ReadLine());
    int n = 5; // размер массива
    int m = 7; // размер массива
  
    int[,] arr = new int[n, m];
    Console.WriteLine("Исходный массив:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] =new Random().Next(0, 10);
            Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
    if (pos1 < 0 | pos1 > arr.GetLength(0)  | pos2 < 0 | pos2 > arr.GetLength(1) )
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", arr[pos1, pos2]);
    }
    Console.ReadLine();

}
Main();
*/
