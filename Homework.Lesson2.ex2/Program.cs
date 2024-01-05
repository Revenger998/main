class Program
{
static void Main()
    {
     Console.Write("Введите координаты точки X и Y:");string[] coordinates = Console.ReadLine().Split(' ');
     int x = Convert.ToInt32(coordinates[0]);
     int y = Convert.ToInt32(coordinates[1]);
        if (x > 0 && y > 0)
        Console.WriteLine("Точка находится в 1 четвери");
            else if (x < 0 && y > 0)
            Console.WriteLine("Точка находится во 2 четвери");
            else if (x < 0 && y < 0)
            Console.WriteLine("Точка находится в 3 четвери");
            else if (x > 0 && y < 0)
            Console.WriteLine("Точка находится в 4 четвери");
        else
        Console.WriteLine("Точка находится на оси координат");
    }
}