public class Player1DeployMap : MapArray
{
    private int mapSize = 10;
    //private AircraftCarrier aircraftCarrier = new AircraftCarrier();
    public static void DrawShip()
    {
        for (int x = 0; x < 3; x++)
        {
            int y = 4;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("¤ ");
                Console.ResetColor();
        }
    }
}