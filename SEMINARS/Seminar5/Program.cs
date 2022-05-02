//Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] ChangeNums(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] *= (-1);

    return array;    
}
*/

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
        Console.Write(array[i] + " ");

    }
    Console.WriteLine();
    return array;
}
int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write("Input " + i + " element: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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


//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

/*
int[] massive = CreateRandomArray(5, 0, 5);
string FindNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            return "contained in the array" ;
        }    
         
    }
    return "not contained in the array";

}

Console.Write("input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindNum(massive, number));
*/
//Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int FindNums(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= 10 && array[i] <= 99)
        {
            count++;
        }
    }

    return count;
}

int[] massive = CreateRandomArray(15, -100, 100);
Console.WriteLine("number of elements: " + FindNums(massive));
*/
//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] NewMagicArray(int[] array)
{
    int newSize = array.Length / 2;
    int[] newArray = new int[newSize];

    for(int i = 0, j = array.Length - 1; i < newSize; i++,j--)
    {
        newArray[i] = array[i] * array[j];
    }

    return newArray;
}

int[] arr = CreateRandomArray(6,1,9);
int[] newArr = NewMagicArray(arr);

ShowArray(newArr);