// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите третье число: ");
int k = int.Parse(Console.ReadLine()!);

int max = n;
if (m>max) max = m;
if (k>max) max = k;

Console.Write("Максимальное число: ");
Console.WriteLine (max);

