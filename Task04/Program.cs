// Задача 4: Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write(" FirstNumber = ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write(" SecondNumber = ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write(" ThirdNumber = ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (FirstNumber > SecondNumber)
{
    if (FirstNumber > ThirdNumber )
    {
        max = FirstNumber;
    }
    else
    {
        max = ThirdNumber;
    }
}
else if (SecondNumber > ThirdNumber)
{
        max = SecondNumber;
}
else
{
        max = ThirdNumber;
}
Console.Write($" Maximum number = {max}");