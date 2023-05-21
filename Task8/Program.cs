// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите число более 1: ");
int n = int.Parse(Console.ReadLine()!);

while (n<2)
{
    Console.Write("Вы ошиблись!\nВведите число более 1: ");
    n = int.Parse(Console.ReadLine()!);
}

for (int i = 2; i <= n; i+=2)
    Console.Write ($"{i} ");
Console.WriteLine();
