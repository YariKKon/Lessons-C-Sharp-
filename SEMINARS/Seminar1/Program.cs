/*

// Задача 1
// Напишите программу, которая на вход принемает целое число и выдает его квадрат (число умноженное само на себя)

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;

Console.WriteLine("Resault is " + result);

 

// Задача 2
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

Console.Write("Input first integer number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
    Console.WriteLine("First number is quad of second number");
else
    Console.WriteLine("First number is not quad of second number");


// Задача 3
// Напишите программу, которая будет выдавать название дня недели по заданому номеру.

Console.Write("Input number of weekday: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day > 7 || day < 1)
{
    Console.WriteLine("Incorect number of day!!!");
}
else
{
    if(day == 1)
        Console.WriteLine("It's Monday");
    if(day == 2)
        Console.WriteLine("it's Tuesday");
    if(day == 3)
        Console.WriteLine("it's Wednesday");
    if(day == 4)
        Console.WriteLine("it's Thursday");
    if(day == 5)
        Console.WriteLine("it's Friday");
    if(day == 6)
        Console.WriteLine("it's Saturday");
    if(day == 7)
        Console.WriteLine("it's Sunday");
}


// Задача 4
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current;

if(num < 0)
{
  current = num;
  num = num * (-1);  
}
else
{
    current = -1 * num;
}

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}


// Задача 5
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 345 % 10 = 5
// 345 / 10 = 34
// 345 / 100 = 3
// 345 % 100 = 45
// (1234 / 100) % 10 = 2

Console.Write("Input integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
    Console.WriteLine("Incorrect number");
else
{
    int a = num % 10;
    Console.WriteLine("Resulted number is " + a);
} 

*/