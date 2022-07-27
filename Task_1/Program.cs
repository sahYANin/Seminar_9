/*
    Задача 64: 
    Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
*/

void f(int n, int m)
{
    if (n != (m - 1))
    {
        f(n - 1, m);
        Console.Write(n + "\t");
    }
}
Console.Write("Задайте значения M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значения N: ");
int n = Convert.ToInt32(Console.ReadLine());

f(n,m);