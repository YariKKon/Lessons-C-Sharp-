// Напишите программу, которая принимает на вход координаты точки (Х и Y), причем X не равен 0 и Y не равен нулю и выдает номер четверти плоскости, в которой находится эта точка.
/*
int FindQvart(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0 )
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else if(x > 0 && y < 0)
        return 4;
    else
        return 0;                    
}


Console.Write("Input X coordinate: ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate: ");
int yDot = Convert.ToInt32(Console.ReadLine());

int qvartNum = FindQvart(xDot, yDot);

if( qvartNum == 0)
    Console.WriteLine("Dot located on the axes!");
else
    Console.WriteLine("Number of quart is " + qvartNum);
*/

// Написать метод в который на вход отпровляется номер четверти. а выводит диапозон точек в этой четверти (x и y).
/*
void Coordinates(int qvad)
{
    if(qvad == 1)
        Console.WriteLine("x > 0, y > 0");
    else if(qvad == 2)
        Console.WriteLine("x < 0, y > 0");
    else if(qvad == 3)
        Console.WriteLine("x < 0, y < 0");
    else if(qvad == 4)
        Console.WriteLine("x > 0, y < 0");
    else
        Console.WriteLine("Wrong number!");                
}

Console.WriteLine("Input qvad number: ");
int qvadNum = Convert.ToInt32(Console.ReadLine());

Coordinates(qvadNum);
*/

//Написать программу которая примет на вход координаты двух точек и найдет расстояние между этими точками в двумерном пространстве.
/*
double DistancePoints(double xA, double yA, double xB, double yB)
{
    return Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
}

Console.WriteLine("Input the coordinates X of the first point");
double xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the coordinates Y of the first point");
double yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the coordinates X of the second point");
double xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the coordinates Y of the second point");
double yB = Convert.ToInt32(Console.ReadLine());

Console.Write(DistancePoints(xA, yA, xB, yB));
*/
//Написать программу которая принемает на вход N натуральное число и выдает таблицу квадратов чисел от 1 до N
/*
void squareTable(int N)
{
    int count = 1;
    Console.Write(N + "-> ");
    while(count <= N)
    {
        Console.Write(count * count + " ");
        count++;
    }
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 0)
    squareTable(num);
else
    Console.Write("Input positive number"); 
*/       