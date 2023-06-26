/*
Задача 19:
Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.Clear();
int number, a1, a2, a4, a5;

try
{
    Console.Write ("Введите пятизначное число: ");
    number = int.Parse (Console.ReadLine() ?? "");
}
catch (Exception exc)
{
    Console.WriteLine ($"Ошибка ввода данных! {exc.Message}");
    return;
}

a1 = number / 10000;
a2 = number % 10000 / 1000;
a4 = number % 100 / 10;
a5 = number % 10;

if (number > 9999 && number < 100000)
{ 
    if (a1 == a5 && a2 == a4)
        Console.WriteLine ($"Пятизначное число {number} является палиндромом!");
    else
        Console.WriteLine ($"Пятизначное число {number} не является палиндромом!");
}
else
{
    Console.WriteLine ("Ошибка ввода! Введено не пятизначное число!");
}