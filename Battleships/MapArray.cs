public class MapArray
{
    //draw maps
    public static void Maps()
{
    Console.WriteLine("(Y)");
    for (int x = 0; x < 10; x++)
    {
        Console.Write($"{9-x} ");
        for (int y = 0; y < 10; y++)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
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