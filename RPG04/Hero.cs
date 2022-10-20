/*The Hero inherits from Unit, has 1000 Health and the name Hero
    Create a Hero when the Game Starts, before the first Monster is spawned.
    The Hero takes 89 Damage each round.
    When the Hero IsDead, the Game is Over.
    Print Game Over. You Lose.
    If the three monsters were killed before the Hero IsDead
Print Game Over. You Win.*/

public class Hero : Unit
{
    public Hero(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) { }

    public override void ReportStatus()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Hero - {Health}/{maxHealth} Health");
        Console.ResetColor();
    }
    
    public override void Attack(Unit target)
    {
        TakeDamage(target.Weapon.Power, target);
        if (target is Skeleton)
        {
            Console.WriteLine("The Hero deals 10 extra Damage against the Skeleton's weak Bones!");
        }

        if (target is Ghost)
        {
            Random random = new Random();
            int chance = random.Next(99);
            Console.WriteLine(chance);
            if (chance < 55)
            {
                Console.WriteLine("The Hero is too scared to attack!");
            }
        }
    }
}