public abstract class MapArray
{
    //initialise map
    private static string[,] map = new String[10, 10];
    public void FillMap()
    {
        for (int x = 0; x < map.Length; x++)
        {
            for (int y = 0; y < map.Length; y++)
            {
                map[x, y] = "~ ";
            }
        }
    }
    public static void DrawMap()
{
    Console.WriteLine("(Y)");
    for (int x = 0; x < 10; x++)
    {
        Console.Write($"{9-x} ");
        for (int y = 0; y < 10; y++)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Console.WriteLine(map[x,y]);
            Console.Write("~ ");
            Console.ResetColor();
        }
        Console.WriteLine();
    }
    Console.Write("\\ ");
    for (int x = 0; x < 10; x++)
    {
        Console.Write($"{x} ");
    }
    Console.Write("(X)");
    Console.WriteLine();
}
}