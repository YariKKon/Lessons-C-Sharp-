// Написать программу которая принимает на вход число, и возращает сумму чисел.
/*
int NaturalSum(int a)
{
    int sum = 0;

    if(a < 1) return 0;
    else
    {
        for(int i = 1; i <= a; i++)
        {
            sum = sum + i;
            //sum +=  i; Выполняет тоже самое что и строка 12.
        }

        return sum;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of elements is " + NaturalSum(num));
*/

// Написать программу которая принемает на вход число и выдает количество цифр в числе.
/*
int Numberofdigits(int n)
{
    int count = 0;
    while( n > 0)
    {
        n /= 10;
        count++;
    }
    return count;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number of digits in a number: " + Numberofdigits(num));
*/
// Написать программу которая принимает на вход число и возращает произведение чисел.
/*
int NaturalProd(int a)
{
    int prod = 1;

    if(a < 1) return 0;
    else
    {
        for(int i = 1; i <= a; i++)
        {
            prod *= i;
            
        }

        return prod;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Product of elements is " + NaturalProd(num));
*/
// Написать программу которая сгенирирует массив и выведит его на экран, массив должен быть заполнен случайным образом нулями и единицами
/*
int[] PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write(arr[i] + " ");
    }
    return arr;
}

int[]array = new int[8];
PrintArray(array);
*/

/* !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
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

void FindSumofElements(int[] array)
{
    int plusSum = 0;
    int minusSum = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            plusSum += array[i];
        else
            minusSum += array[i]; 
    }
    Console.WriteLine("Sum of positive elements is " + plusSum);
    Console.WriteLine("Sum of negative elements is " + minusSum);
}
!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!*/




// Необходимо задать массив из 12 элементов заполненый случайными числами из промежутка от -9 до 9 и найти сумму отрицательных и положительных элементов массива.
/*
int[] myArray = CreateRandomArray(12, -9, 9); 
ShowArray(myArray);
FindSumofElements(myArray);
*/