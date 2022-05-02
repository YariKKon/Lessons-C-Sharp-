/*Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
/*
int Degree(int A, int B)
{
    int a = A;
    int b = B;
    int c = 1;

    for(int i = 0; i < B; i++)
    {
        c = c*a;
    }
    return c;
}

Console.Write("Input nubmer A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Input nubmer B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Degree(A,B));
*/

/*Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*
int SumDigitsNum(int num)
{
    int sum = 0;

    while(num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.Write("Input nubmer: ");
int Num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("The sum of digits in " + Num + " equally " + SumDigitsNum(Num));
*/

/*Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
/*
 void Array()
        {
            
            int[] array = new int[8];
            
 
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(0,99);
                Console.Write(array[i] + " ");
            }
 

        }

Array();
*/