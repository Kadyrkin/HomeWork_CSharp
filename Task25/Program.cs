// // Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число а: ");
int number = Convert.ToInt32(Console.ReadLine());
int degreeNumber = DegreeNumber(number);
Console.WriteLine($"Возведете а в натуральную степень {number} * {degreeNumber} ");
int DegreeNumber(int a, int b) 
    { 
        for (int i = 0; i < b; i++) 
        { 
            a *= a; 
        } 
        return a; 
    } 