/*
Задача 23:
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
Console.Write("Введите целое число: ");
int N = int.Parse(Console.ReadLine() ?? "");
int count = 1;
int cube = 1;

while (count <= N)
{
    cube = count * count * count;
    Console.Write($"{cube}, ");
    count++;
}