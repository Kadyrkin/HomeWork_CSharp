// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую: ");

string[] strNumbers = Console.ReadLine().Split(",");

Console.WriteLine(Count(strNumbers));

int Count(string[] strNumbers)
{
    int cnt = 0; for (int i = 0; i < strNumbers.Length; i++)
    {
        if (Convert.ToInt32(strNumbers[i].Trim()) > 0)
        {
            cnt++;
        }
    }
    return cnt;
}