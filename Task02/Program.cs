// Задача 2: Напишите программу, которая 
// 1.на вход принимает два числа 
// 2.И выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("FirstNumber = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("SecondNumber = ");
int b = Convert.ToInt32(Console.ReadLine());
int min, max;
if(a > b) 
{
   min = b;
   max = a;
}
else if (b > a)
{
    min = a;
    max = b;
}
else 
{
    Console.WriteLine("a=b");
    return;
}
Console.WriteLine($"Минимальное число = {min}; Максимальное число = {max}");