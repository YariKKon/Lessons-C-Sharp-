/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
/*
Console.Write("Input the number of elements: ");
int elem = Convert.ToInt32(Console.ReadLine());

int count = 0;
int num;

for (int i = 0; i < elem; i++)
{
    num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) count++;
}

Console.WriteLine(count + " positive numbers");
*/




/* Напишите программу, которая будет преобразовывать десятичное число в двоичное.

45 -> 101101

3 -> 11

2 -> 10
*/
/*
void TransformDecToBin(int num)
{
    int a = 0; 
    int i = 0;
    int[] b = new int[10];
  
     while (num >= 1)
    {
        a = num % 2;
        b[i] = a;
        num = num / 2;
        i++;
        
    }
    for(int j = i - 1; j >= 0; j--)
    {
        Console.Write(b[j]);
    }
    
}
Console.Write("Input number: ");
int num10 = Convert.ToInt32(Console.ReadLine());
TransformDecToBin(num10);
*/



