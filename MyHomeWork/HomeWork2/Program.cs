/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
/*
Console.Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int ReduceNum(int n)
{
    Console.Write(n + " -> ");
    if(n < 100 || n > 999)
    {
        Console.WriteLine("Incorrect number");
        return n; 
    }
    else
    {
        int result = (n / 10) % 10;
        Console.WriteLine(result); 
        return result;
        
    }
}
ReduceNum(num);
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
/*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

int ThirdNum(int n)
{
    Console.Write(n + " -> ");
    while(n > 999)
    {
        n = n / 10;
    }
    if(n < 100)
    {
        Console.WriteLine("no third digit");
        return n;
    }
    else
    {
        int result = (n % 10)  ;
        Console.WriteLine(result);
        return result;
    }
   

}
ThirdNum(num);
*/


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
Console.Write("Input the number of the day of the week: ");
int day = Convert.ToInt32(Console.ReadLine());

void Weekend( int d)
{
    Console.Write(d + " -> ");

    if( d > 5 && d < 8)
    {
        Console.WriteLine("Weekend");
    }
    else
    {
         if(d < 1 || d > 7)
        Console.Write("Incorect number of day!!!");
        else
        Console.Write("Weekday");
    }
   
        
}
Weekend(day);
*/

