/*The Hero inherits from Unit, has 1000 Health and the name Hero
    Create a Hero when the Game Starts, before the first Monster is spawned.
    The Hero takes 89 Damage each round.
    When the Hero IsDead, the Game is Over.
    Print Game Over. You Lose.
    If the three monsters were killed before the Hero IsDead
Print Game Over. You Win.*/

public class Hero : Unit
{
    /*public string name
    {
        get;
        private set;
    }

    public int maxHealth
    {
        get;
        private set;
    }
    public Weapon weapon { get; }*/
    
    public Hero(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) { }
    /*public override bool IsDead
    {
        get
        {
            if (health <= 0)
            {
                Console.WriteLine("Game Over. You lose");
                return true;
            }
            return false;
        }
    }*/
    public void ReportStatus()
    {
        //Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Hero - {health}/{maxHealth} Health");
        //Console.ResetColor();
    }
}