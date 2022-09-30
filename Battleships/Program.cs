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

Console.WriteLine("Lets try to make Battleship");

//declare arrays & variables
char[,] player1DeployMap = new char[9, 9];
char[,] player1AttackPlot = new char[9, 9];
char[,] player2DeployMap = new char[9, 9];
char[,] player2AttackPlot = new char[9, 9];
int bearing;
int attackPlotX;
int attackPlotY;

Maps();
CompPlayerAttack();

//draw maps
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

Console.WriteLine("<¤");
Console.WriteLine("<¤-");
Console.WriteLine("<¤>");
Console.WriteLine("<¤¤-");
Console.WriteLine("<¤¤¤-");
Console.WriteLine();
Console.WriteLine("A");
Console.WriteLine("¤");
Console.WriteLine("¤");
Console.WriteLine("¤");
Console.WriteLine("|");