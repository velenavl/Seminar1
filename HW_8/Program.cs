﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int i = 1;
bool not = true;

int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + N);
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write(i + ", ");
        not = false;
    }
    i++;
    }

if (not)
{
    Console.WriteLine("Нет чётных чисел!");
}