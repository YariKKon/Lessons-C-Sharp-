/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/
/*
Console.Write("Input size of m: ");
int size1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input size of n: ");
int size2 = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[size1, size2];

for (int i = 0; i < size1; i++)
{
    for (int j = 0; j < size2; j++)
    {
        matrix[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
        Console.Write(Math.Round(matrix[i, j], 1) + "  ");  // Нашел Math.Round в документации microsoft, что бы избавится от огромного количества цифр после зяпотой.))

    }
    Console.WriteLine();
}

*/

/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
/*
Console.Write("Input elements: ");
int number = Convert.ToInt32(Console.ReadLine());

string ElementSearch(int[,] matrix, int num)
{


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == num)
            {


                return num + " -> There is such a number in the array";
            }


        }
        Console.WriteLine();
    }
    return num + " -> There is no such number in the array";
}

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(ElementSearch(matrix, number));
*/

/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
/*
int[,] matrix = new int[3, 4];

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + "\t  ");

    }
    Console.WriteLine();
}


void ArithmeticMeanOfTheElrmrnts(int[,] matrix)
{
    double meanArithmetic = 0;
    Console.Write("Arithmetic mean of each column: ");
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            meanArithmetic += matrix[i, j];
        }
        meanArithmetic /= matrix.GetLength(0);
        Console.Write(Math.Round(meanArithmetic, 1) + "; ");
        meanArithmetic = 0;
    }
    Console.WriteLine();
}
ArithmeticMeanOfTheElrmrnts(matrix);
*/