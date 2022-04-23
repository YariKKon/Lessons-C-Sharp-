

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}

/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
/*
void NumberOfEvenNumbers(int[] array)
{
    int even = 0;

    for(int i = 0; i< array.Length; i++)
    {
        if(array[i] % 2 == 0)
            even++;
    }
    Console.Write("Number of even numbers: " + even);

}


int[] myarray = CreateRandomArray(4, 100, 999);
ShowArray(myarray);
NumberOfEvenNumbers(myarray);
*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
/*
int[] myarray = CreateRandomArray(4, -99,99);
ShowArray(myarray);

void SumOfOddPositions(int[] array)
{
    int sumOdd = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sumOdd += array[i];

    }
    Console.Write("Sum of odd positions: " + sumOdd);
}
SumOfOddPositions(myarray);
*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
/*
double[] CreateArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void ShowArray1(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine();
}
double[] myarray = CreateArray(5);
ShowArray1(myarray);

void DeferenceMaxAndMin(double[] array)
{
    double max = 1;
    double min = 0;
    double result = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
            max = array[i];
        if(array[i] < min)
            min = array[i];
        
        
    }
    result = max - min;
    Console.Write("Difference between maximum and minimum element: " + result);

}
DeferenceMaxAndMin(myarray);
*/