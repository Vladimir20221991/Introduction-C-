// string name = "Vladimir";
// char symbol = '*';
// char[] symbol2 = {'V', 'l', 'a', 'd', 'i', 'm', 'i', 'r'};
// Console.WriteLine(symbol2);

//string[] names = { "Vladimir", "Mariya", "Artem" };

//Console.WriteLine(names[1]);

/*
int CountEven(string[] words)
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length % 2 == 0) count++;
    }
    return count;
}

string[] names = { "Vladimir", "Mariya", "Artem" };
Console.WriteLine(CountEven(names));
*/

//Console.WriteLine(('c' > 'e'));
/*
string[] SortArray(string[] words)
{
    string temp = string.Empty;
    for (int i = 0; i < words.Length - 1; i++)
    {
        for (int j = 0; j < words.Length - 1 - i; j++)
        {
            if (words[j].Length > words[j + 1].Length)
            {
                temp = words[j];
                words[j] = words[j + 1];
                words[j + 1] = temp;
            }
            else if (words[j].Length == words[j + 1].Length)
            {
                for (int k = 0; k < words[j].Length; k++)
                {
                    if (words[j][k] > words[j + 1][k])
                    {
                        temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                        break;
                    }
                    else if (words[j][k] < words[j + 1][k]) break;
                }
            }
        }
    }
    return words;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

string[] names = { "Vladimir", "Marina", "Mariya", "Artem", "Artim" };
PrintArray(SortArray(names));
*/
/*
int a = 5, b = 10;

a = (b % 2 == 0) ? b : 0;

if (b % 2 == 0)
{
    a = b;
}
else
{
    a = 0;
}
Console.WriteLine(a);
*/
