// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели"); 
int day = Convert.ToInt32(Console.ReadLine()); 
if (day == 1) 
{ 
    Console.Write("Понедельник : - нет "); 
} 
else if (day == 2) 
{ 
    Console.Write("Вторник : - нет "); 
} 
else if (day == 3) 
{ 
    Console.Write("Среда : - нет "); 
} 
else if (day == 4) 
{ 
    Console.Write("Четверг : - нет "); 
} 
else if (day == 5) 
{ 
    Console.Write("Пятница : - всё ещё нет"); 
} 
else if (day == 6) 
{ 
    Console.Write("Суббота : - да, выходной!!!!"); 
} 
else if (day == 7) 
{ 
    Console.Write("Воскресенье : - да, выходной, но завтра снова понедельник "); 
} 
else 
Console.WriteLine("День недели не найден, попробуйте ввести цифры от 1 до 7 ");