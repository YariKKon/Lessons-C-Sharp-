/* Задача 1 
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.



void ShowNumber()
{
    int num = new Random().Next(10,99);
    int firsNum = num / 10;
    int secondNum = num % 10;

    Console.Write(num + "->");

    if(firsNum > secondNum)
    {
        Console.WriteLine(firsNum);
    }
    else
    {
        Console.WriteLine(secondNum);
    }
}
ShowNumber();

*/

/* Задача 2 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.(456 -> 46)
Задача 3 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
Задача 4 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Задача 5 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

*/

/*
void RemoveSecondDigit()
{
    int num = new Random().Next(100,999);
    Console.Write(num + "->" );
    int n1 = num % 10;
    int n3 = num / 100;
    int result = n3 * 10 + n1;
    Console.Write(result);
}
RemoveSecondDigit();
*/
/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int Multiplicity(int n1, int n2)
{
    int result = n2 % n1;
    if(result == 0 )
    {
        Console.WriteLine(n2 + " is multiplicity of " + n1 );
        return result;
    }
    else
    {
        Console.WriteLine(n2 + " is not a multiplicity of " + n1 );
        Console.WriteLine("remainder: " + result);
        return result;
    }
}
Multiplicity(num1, num2);
*/
/*
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

void Multiple(int n)
{
    if(num % 7 == 0 && num % 23 == 0)
    {
        Console.Write(num + " is multiple of 7 and 23");
    }
    else
    {
        Console.Write(num + " id NOT mulriple of 7 and 23");
    }
}
Multiple(num);
*/
/*
Console.Write("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Square(int n1, int n2)
{
    if(n1 == n2 * n2)
    {
        Console.Write(n1 + " is a square " + n2);
    }
    else
    {
        Console.Write(n1 + " is NOT a square " + n2);
    }
}
Square(num1, num2);
*/