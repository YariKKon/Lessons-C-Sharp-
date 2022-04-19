/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
/*
Console.Write("Input a five-digit number: ");
int pNum = Convert.ToInt32(Console.ReadLine());

void Palindrome(int num)
{
    Console.Write(num + "-> ");
    int tn = num;
    int rev = 0;
    while(num > 0)
    {
        rev = rev * 10 + num % 10;
        num = num / 10;
    
    }
    if(tn == rev)
        Console.Write("Palindrome");
    else
        Console.Write("Not a palindrome");    
}
Palindrome(pNum);
*/
/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double DistancePoints3D(double xA, double yA, double xB, double yB, double zA, double zB)
{
    return Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
}

Console.Write("Input the coordinates X of the first point: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the coordinates Y of the first point: ");
double yA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the coordinates Z of the first point: ");
double zA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the coordinates X of the second point: ");
double xB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the coordinates Y of the second point: ");
double yB = Convert.ToInt32(Console.ReadLine());
Console.Write("Input the coordinates Z of the second point: ");
double zB = Convert.ToInt32(Console.ReadLine());

Console.Write("Distance between points: " + DistancePoints3D(xA, yA, xB, yB, zA, zB));
*/

/*адача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
void cobeTable(int N)
{
    int count = 1;
    Console.Write(N + "-> ");
    while(count <= N)
    {
        Console.Write(count * count * count + " ");
        count++;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0)
    cobeTable(num);
else
    Console.Write("Input positive number");
*/