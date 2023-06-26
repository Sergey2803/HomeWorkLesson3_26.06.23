/*
Задача 21:
Напишите программу, которая принимает на вход 
координаты двух точек и находит расстояние между 
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();
int x1 = 0, y1 = 0, z1 = 0, x2 = 0, y2 = 0, z2 = 0;
InitCoordinatesByUser(ref x1, ref y1, ref z1, ref x2, ref y2, ref z2);
PrintDistancePoints3D(x1, y1, z1, x2, y2, z2);

static void InitCoordinatesByUser   (ref int x1, ref int y1, 
                                    ref int z1, ref int x2, 
                                    ref int y2, ref int z2)
{
    try
    {
        Console.Write("Введите координату X точки A: ");
        x1 = int.Parse(Console.ReadLine() ?? "");  
    
        Console.Write("Введите координату Y точки A: ");
        y1 = int.Parse(Console.ReadLine() ?? "");
    
        Console.Write("Введите координату Z точки A: ");
        z1 = int.Parse(Console.ReadLine() ?? "");  
    
        Console.Write("Введите координату X точки B: ");
        x2 = int.Parse(Console.ReadLine() ?? "");  
    
        Console.Write("Введите координату Y точки B: ");
        y2 = int.Parse(Console.ReadLine() ?? "");
    
        Console.Write("Введите координату Z точки B: ");
        z2 = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine ($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

static void PrintDistancePoints3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double distance = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    Console.WriteLine ($"A({x1},{y1},{z1}), B({x2},{y2},{z2}) -> {distance:f2}");
}