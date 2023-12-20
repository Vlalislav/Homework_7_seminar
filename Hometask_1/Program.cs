// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.WriteLine("ВВедите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите N");
int n = Convert.ToInt32(Console.ReadLine());
BetweenNumbers(m,n);

static int BetweenNumbers(int m, int n)
{
    if (m==n+1) return n;
    Console.Write(m+" ");
    return BetweenNumbers(m+1,n);

}