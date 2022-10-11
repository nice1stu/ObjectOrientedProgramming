/*2 Players
10 x 10 grid per player
Simplified Ship Sizes: Only 5x 1 sized ships
Players take alternating turns
Coordinates given in the form g7, a2, d2 etc...
consider using the numeric value of chars! :)
can be simplified at first with two inputs:
first: int x
then: int y
Feedback "Hit" or "Miss"
Win Condition: All enemy ships have been sunk
Bonus Rules (A*):
Ships: sizes 5, 4, 3, 2 ships with 2
Ships may be placed vertically or horizontally
Ships may not overlap and may not touch each other (i.e. there needs to be at least 1 empty grid cell around the ship in every direction)
Feedback "Ship sunk!"
Bonus Bonus (No score):
A.I.? :)
Radar Power Up
Can be used to detect ships in a 3x3 radius around the location placed (but not hit them)
Can you think of other power-ups? :)
Scanner Power Up
Can be used to scan a 3x3 radius around the location placed
Only returns "Ship detected" or "No ship detected"*/

using System.ComponentModel.Design;

Console.WriteLine("Lets try to make Battleship");

//declare arrays & variables
char[,] player1DeployMap = new char[10, 10];
//char[,] player1AttackPlot = new char[9, 9];
//char[,] player2DeployMap = new char[9, 9];
//char[,] player2AttackPlot = new char[9, 9];
int[] startPosition = new int[2];
int bearing;
int xInput= 0;
int yInput = 0;
string shipBearing = null;
string namePlayer1 = null;
string namePlayer2;

SetUp();
ArrayMap();
AircraftCarrier();
//Maps();
//CompPlayerAttack();

/*draw maps
void Maps()
{
    Console.WriteLine("(Y)");
    for (int x = 0; x < 10; x++)
    {
        Console.Write($"{9-x} ");
        for (int y = 0; y < 10; y++)
        {
            Console.Write("~ ");
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
}*/

void SetUp()
{
    Console.WriteLine("Welcome to Battleships");
    Console.WriteLine("Choose [1] or [2] Players");
    int userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput == 1)
    {
        Console.WriteLine("Player 1, please enter your name.");
        namePlayer1 = Console.ReadLine();
        Console.WriteLine($"Welcome {namePlayer1}, Good Hunting!");
        //pause 3 seconds
        //DeployShips();
    }
    else
    {
        Console.WriteLine("Player 1, please enter your name.");
        string namePlayer1 = Console.ReadLine();
        Console.WriteLine($"Welcome {namePlayer1}, Good Hunting!");
        Console.WriteLine("Player 2, please enter your name.");
        string namePlayer2 = Console.ReadLine();
        Console.WriteLine($"Welcome {namePlayer2}, Good Hunting!");
        //DeployShips();
    }
}

/*void DeployShips()//change to player n
{
    int x = xInput;
    int y = yInput;
    Console.WriteLine("Ship Classes:");
    Console.WriteLine("[1] Aircraft Carrier - 5 Squares");
    Console.WriteLine("[2] Cruiser - 4 Squares");
    Console.WriteLine("[3] Destroyer - 3 Squares");
    Console.WriteLine("[4] Submarine - 3 Squares");
    Console.WriteLine("[5] Corvette - 2 Squares");
    Console.WriteLine(namePlayer1 + " select which ship to deploy");
    Console.WriteLine();
    string userInput = Console.ReadLine();
    // select ship class
    Console.WriteLine("Select the starting co-ordinate of your ship [x,y]");
    Console.WriteLine("please enter the X co-ordinate");
    xInput = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("please enter the Y co-ordinate");
    yInput = Convert.ToInt32(Console.ReadLine());
    startPosition[x,y] = xInput, yInput;
    Console.WriteLine("Then choose to deploy [v]ertically down or [h]orizontally across");
    string shipBearing = Console.ReadLine();
    //player 1 sets ships on player1Deploy map x 5
    //player 2 sets ships om player2Deploy map x 5
}*/

void AircraftCarrier()
{
    int x = 4;//xInput;
    int y = 4;//yInput;
    shipBearing = "h";
    if (shipBearing == "h") // set ship horizontally from start co-ordinates
    {
        
        for (x = 0; x < 5; x++)
        {
            player1DeployMap[x, yInput] = '¤';
        }
    }
}
    
//Create Array Map
void ArrayMap()
{
    Console.WriteLine(namePlayer1 + ", Deploy your ships");
    for (int x = 0; x < player1DeployMap.GetLength(0); x++)
    {
        for (int y = 0; y < player1DeployMap.GetLength(1); y++)
        {
            player1DeployMap[x, y] = '~';
        }
    }

    Console.WriteLine("(Y)");
    for (int x = 0; x < player1DeployMap.GetLength(0); x++)
    {
        Console.Write($"{9 - x} ");
        for (int y = 0; y < player1DeployMap.GetLength(1); y++)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{player1DeployMap[x, y]} ");
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
}

//generate random Bearing (veritcal or horizontal)
void Bearing()
{
    Random random = new Random();
    bearing = random.Next(0, 2);
    if (bearing % 2 == 0)
    {
        //vertical (y Axis)
        Console.WriteLine(bearing);
    }
    else
    {
        //horizontal (x Axis)
        Console.WriteLine(bearing);
    }
}

//AI player random attack
void CompPlayerAttack()
{
    Random random = new Random();
    int attackPlotX = random.Next(0, 9);
    int attackPlotY = random.Next(0, 9);
    Console.WriteLine($"{attackPlotX}, {attackPlotY}"); //CompPlayerAttack co-ordinates
}

Ships aircraftCarrier = new Ships("AircraftCarrier", 5);
Ships cruiser = new Ships("Cruiser", 4);
Ships destroyer = new Ships("Destroyer", 3);
Ships submarine = new Ships("Submarine", 3);
Ships corvette = new Ships("Corvette", 2);

public class Ships
{
    public string ShipType;
    public int ShipLength;

    public Ships(string shipType, int shipLength)
    {
        this.ShipType = shipType;
        this.ShipLength = shipLength;
    }
}

/*void GameMechanic()
{
    //gamePlay
    //while gameOver != true
    // n %2 to alternate players
    //display playerAttackPlot[n]
    //player1 attacks by selecting x,y co-ordinates on playerAttackPlot[n]
    //attack resolved on playerDeploy[!n] map
    //Hits change map to "X". Miss change map to "O"
    //check if ship sunk
    //check if game over
    //hit key to change to next player
}*/

