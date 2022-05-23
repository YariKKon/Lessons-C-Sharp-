/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8
*/

int[,] CreateMatrix(int row, int colum)
{
    int[,] matrix = new int[row, colum];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return matrix;

}

void PrintArray(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
/*
int[,] ArrangeAscending(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int minPos = j;
            for (int k = j + 1; k < matrix.GetLength(1); k++)
            {
                if (matrix[i, k] < matrix[i, minPos]) minPos = k;
            }
            int tmp = matrix[i, j];
            matrix[i, j] = matrix[i, minPos];
            matrix[i, minPos] = tmp;
        }

    }
    return matrix;
}

Console.Write("Input height matrix: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Input width matrix: ");
int width = Convert.ToInt32(Console.ReadLine());

PrintArray(ArrangeAscending(CreateMatrix(height, width)));
*/

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
/*
int SmallestSumRows(int[,] matrix)
{
    int stringSum = 0, minStringSum = 0, rowIndex = 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        stringSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == 0)
            {
                minStringSum += matrix[i, j];
                stringSum += matrix[i, j];
            }
            else
                stringSum += matrix[i, j];
        }
        if (minStringSum > stringSum)
        {
            rowIndex = i + 1;
            minStringSum = stringSum;
        }
    }
    return rowIndex;
}

Console.Write("Input height matrix: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Input width matrix: ");
int width = Convert.ToInt32(Console.ReadLine());
int result = SmallestSumRows(CreateMatrix(height, width));
Console.WriteLine($"The smallest sum of elements in {result} line.");
*/

/*Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7
*/
/*
int[,] CreateSpriralArray(int m, int n)
{

    int[,] matrix = new int[n, m];

    int row = 0;
    int col = 0;
    int deltaCol = 1;
    int deltaRow = 0;
    int dirChanges = 0;
    int limit = m;

    for (int i = 0; i < matrix.Length; i++)
    {
        matrix[row, col] = i + 1;

        limit--;
        if (limit == 0)
        {
            limit = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = deltaCol;
            deltaCol = -deltaRow;
            deltaRow = temp;
            dirChanges++;
        }

        col += deltaCol;
        row += deltaRow;
    }
    return matrix;
}

Console.Write("Input height matrix: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Input width matrix: ");
int width = Convert.ToInt32(Console.ReadLine());

PrintArray(CreateSpriralArray(height, width));
*/