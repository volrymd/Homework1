// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int m = int.Parse(Console.ReadLine()!);

if (n>m)
    Console.WriteLine("Первое число больше второго");
else if (m>n)
    Console.WriteLine("Второе число больше первого");
else
    Console.WriteLine("Числа равны");
