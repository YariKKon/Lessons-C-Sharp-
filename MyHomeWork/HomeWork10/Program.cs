/* Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.

Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1
*/


/*
int BeginningVowelLetter(string[] words)
{
    int count = 0;
    string  vowels = "aeiouy"; 
    for (int i = 0; i < words.Length; i++)
    {
        for (int j = 0; j < vowels.Length; j++)
        {
            if(words[i][0] == vowels[j]) count++;
           
        }
    }
    return count;
}

void PrintArrayString(string[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write('"' + array[i] + '"');
        if(i == array.Length - 1)
        {
            Console.Write("} ");
        }
        else
        {
            Console.Write(", ");
        }
    }
}

string[] words = { "qwe", "wer", "ert", "rty", "tyu"};
PrintArrayString(words);
Console.WriteLine("--> " + BeginningVowelLetter(words));

*/

/*Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}
*/
/*
string[] CombineElementsPairs(string[] words)
{
    string[] CombinedElements = new string[words.Length / 2];
    for (int i = 0, j = 0; i < CombinedElements.Length; i++, j += 2)
    {
        CombinedElements[i] = words[j] + words[j + 1];
    }
    return CombinedElements;
}
void PrintArrayString(string[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write('"' + array[i] + '"');
        if(i == array.Length - 1)
        {
            Console.Write("}");
        }
        else
        {
            Console.Write(", ");
        }
    }
}
string[] words = {"qwe", "wer", "ert", "rty", "tyu", "yui"};
PrintArrayString(words);
string[] newArray = CombineElementsPairs(words);
Console.Write("  -->  ");
PrintArrayString(newArray);
*/