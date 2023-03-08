// // Задача 24: Напишите программу, которая
// 1. принимает на вход число (А) и 
// 2. выдаёт сумму чисел
// 3. Создать метод

// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Ведите целое положительное число: ");
int number =  Convert.ToInt32(Console.ReadLine());
int sumNumbers = SumNumbers(number);
Console.WriteLine ($"Сума чисел от 1 до {number} = {sumNumbers}");
int SumNumbers(int num)
{
    int sum = 0;
    for(int i = 1; i < num; i++)
{
       sum = sum + i;
}
return sum;
}
