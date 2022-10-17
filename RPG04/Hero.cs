/*The Hero inherits from Unit, has 1000 Health and the name Hero
    Create a Hero when the Game Starts, before the first Monster is spawned.
    The Hero takes 89 Damage each round.
    When the Hero IsDead, the Game is Over.
    Print Game Over. You Lose.
    If the three monsters were killed before the Hero IsDead
Print Game Over. You Win.*/

public class Hero : Unit
{
    internal static string name = "Hero";
    internal static int maxHealth = 1000;
    internal static int power = 66;
    public Hero(string name, int maxHealth, int power) : base(name, maxHealth, power)
    {
    }
    public override bool IsDead
    {
        get
        {
            if (health <= 0)
            {
                Console.WriteLine("Game Over. You lose");
                //gameOver = true;
                return true;
            }
            return false;
        }
    }
}