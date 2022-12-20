// See https://aka.ms/new-console-template for more information
//Напишите программу  которая на вход принимает два числа и 
//  выдаёт, какое число большее, а какое меньшее.
// ВАРИАНТ А
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Первое число больше второго");
}
else
{
    Console.WriteLine("Второе число больше первого");
}
// ВАРИАНТ Б
Console.WriteLine("Введите первое число:");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");

//Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a)
{
    max = b;
}
    max = b;
if (c > max)
{
    max = c;
}
    
Console.WriteLine("Максимальное из этих чисел: " + max);

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"Число  {num}  является: ЧЁТНЫМ ДЕЛИТСЯ НА ДВА БЕЗ ОСТАТКА");
}
else
{
    Console.WriteLine($"Число  {num}  является: НЕЧЁТНЫМ ");
}

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
int res = 1;
while (res < num)
{
    Console.WriteLine(res + 1);
    res+= 2;
}