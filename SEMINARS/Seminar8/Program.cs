// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

/*
int[,] ChangeRowCol(int[,] matrix)
{
    int tmp = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        tmp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = tmp;
        
    }
    return matrix;
}
*/

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
Console.Write("Input height matrix: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Input width matrix: ");
int width = Convert.ToInt32(Console.ReadLine());
PrintArray(ChangeRowCol(CreateMatrix(height, width)));
*/
//Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*

int[,] ChangeRowToCol(int[,] matrix)
{
    int tmp = 0;
    int k = matrix.GetLength(0) - 1;
    int l = matrix.GetLength(1) - 1;
    for (int i = 0; i <= k; i++)
    {
        for (int j = i + 1; j <= l; j++)
        {
            tmp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = tmp;
        }
    }
    return matrix;
}

Console.Write("Input height matrix: ");
int height = Convert.ToInt32(Console.ReadLine());
Console.Write("Input width matrix: ");
int width = Convert.ToInt32(Console.ReadLine());

if (height == width)
{
    PrintArray(ChangeRowToCol(CreateMatrix(height, width)));
}
else
{
    Console.WriteLine("Cannot change row to column. Matrix is not square.");
}

*/