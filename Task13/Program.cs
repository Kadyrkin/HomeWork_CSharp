﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
SimpleMethod(Convert.ToInt32(Console.ReadLine())); 
        void SimpleMethod(int num) 
        { 
            if (num < 100) 
            { 
                Console.WriteLine("Третья цифра отсутствует"); 
            } 
            else if (num < 1000) 
            { 
                Console.WriteLine(num % 10); 
            } 
            else 
            { 
                int i = 10; 
                while (true) 
                { 
                    if (num / i < 1000) 
                    { 
                        Console.WriteLine(num / i % 10); 
                        break; 
                    } 
                    else 
                    { 
                        i *= 10; 
                    } 
                } 
            } 
        }