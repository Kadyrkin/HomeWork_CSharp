// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write($"{number} -> {SumDigits(number)}.");

int SumDigits(int number_value)
{
    int buffer = number_value, sum = 0;
    while (buffer > 0)
    {
        sum += buffer % 10; 
        buffer /= 10;
    }
    return sum;
}
