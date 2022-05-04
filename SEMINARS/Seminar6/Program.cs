// A < B + C где A,B,C - стороны треугольника
/* 
 bool IsTriangleExist(int a, int b, int c)
 {
     if (a < b + c && b < a + c && c < a + b)
     {
         return true;
     }

     return false;
 }

 if (IsTriangleExist(1, 2, 3))
 {
     Console.WriteLine("Yes");
 }
 else
 {
     Console.WriteLine("No");
 }
 */

// Написать программу которая принемая одномерный массив и возращает его перевернутую версию.

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

/*
int[] Revers(int[] array) // разворот с созданием второго массива
{
    int newSize = array.Length;
    int[] newArray = new int[newSize];

    for (int i = 0, j = newSize - 1; i < newSize; i++, j--)
    {
        newArray[i] = array[j]; 
    }
    return newArray;
}
*//*
int [] TurnArray(int[] arr) // разворот внутри массива
{
    int temp = 0;

    for(int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
    {
        temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }
    return arr;
}

int[] myArray = CreateRandomArray(10, 0, 10);
ShowArray(myArray);
int[] newArr = TurnArray(myArray);
ShowArray(newArr);

*/


//Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
/*
int[] GetFibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

int[] newArray = GetFibonacci(10);
ShowArray(newArray);
*/
