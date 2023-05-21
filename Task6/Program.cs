// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);

if (n % 2 == 0)
    Console.WriteLine("Число четное");
else
    Console.WriteLine("Число нечетное");