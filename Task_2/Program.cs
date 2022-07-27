/*
    Задача 66: 
    Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от N до M.
*/

int f(int n, int m)
{
    if (n > m)
        return 0;
    return f(n + 1, m) + n;
}
Console.Write("Задайте значения N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте значения M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write(f(n, m));