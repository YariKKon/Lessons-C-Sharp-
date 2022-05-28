//Пользователь вводит чсило n, написать рекурсивный метод который выведит все натуральные число от 1 до n.
/*
NaturalNums(5);

void NaturalNums(int n)
{
    if (n >= 1)
    {
        NaturalNums(n - 1);
        Console.Write(n + " ");
    }
}
*/

// n^m = n * n * n * n.....



int Recurs(int n, int m)
{
    if (m >= 1)
    {
        return n * Recurs(n, m - 1);

    }
    else
        return 1;
}

Console.WriteLine(Recurs(5, 4));