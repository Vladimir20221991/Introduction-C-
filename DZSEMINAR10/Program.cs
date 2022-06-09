// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
// Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
/*
int CountStartVowel(string[] array)
{
    char[] vowelLetters = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u', 'Y', 'y' };
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < vowelLetters.Length; j++)
        {
            if (array[i][0] == vowelLetters[j])
            {
                counter++;
            }
        }
    }
    return counter;
}
void PrintArrayString(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
string[] words = { "Alexey", "qwe", "wer", "ert", "rty", "tyu","Anna" };
Console.Clear();
PrintArrayString(words);
Console.Write("-> " + CountStartVowel(words));
Console.WriteLine();
Console.WriteLine();
*/

// Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, 
// объединяя элементы исходного массива попарно.
// Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
/*
string[] Delicious(string[] array)
{
    string[] DeliciousArray = new string[array.Length / 2];
    for (int i = 0, j = 0; i < DeliciousArray.Length; i++,j+=2)    
    {
        DeliciousArray[i] = array[j] + array[j+1];
    }
    return DeliciousArray;
}
void PrintArrayString(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
Console.Clear();
string[] words = { "qwe", "wer", "ert", "rty", "tyu", "yui"};
Console.WriteLine();
PrintArrayString(words);
Console.WriteLine();Console.WriteLine();
PrintArrayString(Delicious(words));Console.WriteLine();Console.WriteLine();
*/
