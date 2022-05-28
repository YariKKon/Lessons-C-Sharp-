/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
int SumNarural(int m, int n)
{
    if (n >= m)
    {
        return m + SumNarural(m + 1, n);
    }
    else
        return 0;
}

Console.Write("Input the initial number M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the initial number N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of natural numbers from {numberM} to {numberN} is equal to {SumNarural(numberM, numberN)}");

*/

/*Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

453 -> 12

45 -> 9
*/
/*
int SumDigitsNumber(int num)
{
    if(num > 0)
        return num % 10 + SumDigitsNumber(num/10);
    else
        return 0;    
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{number} --> {SumDigitsNumber(number)}");
*/