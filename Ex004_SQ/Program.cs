// Написать программу, которая на вход принимает 2 числа и проверяет является ли первое число квадратом второго.

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int resulte = numberB * numberB;

if (resulte == numberA)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}