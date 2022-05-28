/*
string name = "Yaroslav";
char symbol = '*';
char[] symbol2 = { 'Y', 'a', 'r', 'o', 's', 'l', 'a', 'v' };

string[] names = {"Yaroslav", "Yarik", "XuDeKu"};
Console.WriteLine(names[1][2]);
*/

// Метод принимает на вход массив строк и возращает число, сколько в массиве элементов с четным количеством символов.
/*
int CountEven(string[] words)
{
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        if(words[i].Length % 2 == 0) count++;
    }

    return count;
}

string[] names = {"Yaroslav", "Yarik", "XuDeKu"};
Console.Write(CountEven(names));
Console.WriteLine(" ");
Console.WriteLine(('c' > 'C'));
*/
/*
string[] names = { "Yaroslav", "Yarik", "XuDeKu", "Pavel", "Max" };

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
                for (int k = 0; k < words.Length; k++)
                {
                    if (words[j][k] > words[j + 1][k])
                    {
                        temp = words[j];
                        words[j] = words[j + 1];
                        words[j + 1] = temp;
                        break;
                    }
                    else if(words[j][k] < words[j + 1][k]) break;
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

PrintArray(names);
Console.WriteLine();
PrintArray(SortArray(names));
*/

int a = 5, b = 10;

a = (b % 2 == 0) ? b : 0; // тернарный оператор

if (b % 2 == 0)
{
    a = b;
}
else
{
    a = 0;
}

Console.WriteLine(a);