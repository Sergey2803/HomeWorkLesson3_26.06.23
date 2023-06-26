/*
Задача 23:
Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Clear();
int N = 0, count = 1, cube = 1;
InitNByUser(ref N);
PrintCube(cube, N, count);

static void InitNByUser(ref int N)
{
    Console.Write("Введите целое число: ");
    N = int.Parse(Console.ReadLine() ?? "");
}

static void PrintCube(int cube, int N, int count)
{
    while (count <= N)
    {
        cube = count * count * count;
        Console.Write($"{cube}, ");
        count++;
    }
}