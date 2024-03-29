﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите число А:");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B:");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB < 0) Console.WriteLine("Число B не может быть отрицательным!");
else Console.Write($"{numberA} в {numberB} степени = {Exponentiation(numberA, numberB)}.");

int Exponentiation(int nmbrA_value, int nmbrB_value)
{
    int result = 1;
    for (int i = 0; i < nmbrB_value; i++) result *= nmbrA_value;
    return result;
}