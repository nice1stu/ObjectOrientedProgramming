/*The Bomb inherits from Unit, has 500 Health, the name Bomb and this Special Ability:
It explodes after 5 Rounds
When exploding, the Bomb's Health is set to 0
Print Unit #3: Bomb has exploded!
Add these three new monsters to your SpawnNewUnit-Method
extend the Random Number to give results between 0 and 2
And map each of these numbers to a Unit that is then created

Implement the Bomb's Explosion Feature fully: When it explodes after 5 rounds, it deals 500 Damage to the Player.*/

namespace RPG;

public class Bomb : Unit
{
    private int count2Five;

    public Bomb(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) {}
    public override void TakeDamage(int value, Unit opponent)
    {
        base.TakeDamage(value, opponent);
        
        if (count2Five >= 4)
        {
            Health = 0;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*** BOOM! *** Bomb has exploded");
            Console.ResetColor();
            opponent.TakeDamage(500, this);
            return;
        }
        
        count2Five++;
    }
}