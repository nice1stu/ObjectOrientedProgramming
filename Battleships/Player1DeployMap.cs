public class Player1DeployMap : MapArray
{
    private int mapSize = 10;
    //private AircraftCarrier aircraftCarrier = new AircraftCarrier();
    private int[,] aircraftCarrier =
    {
        { 0, 5 },
        { 1, 5 },
        { 2, 5 },
        { 3, 5 },
        { 4, 5 }
    };
    void DrawShip()
    {
        for (int i = 0; i < 5; i++)
        {
            
            Console.Write("¤");
            
        }
    }
}