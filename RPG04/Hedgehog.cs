/*The Hedgehog inherits from Unit, has 200 Health, the name Hedgehog and this Special ability:
When hit, he goes into Defense Mode for 2 Rounds
Print Unit #3: Hedgehog went into Defense Mode!
After 2 rounds, he stops being in Defense Mode
Print Unit #3: Hedgehog stopped being into Defense Mode!
While in Defense Mode, the Hedgehog does not take any Damage from the Player
Print Unit #3: Hedgehog was hit while in Defense Mode!*/

public class Hedgehog : Unit
{

    public static Weapon weapon { get; }
    
    private int tookDamage;
    public Hedgehog(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) {}
    public override void TakeDamage(int value, Unit opponent)
    {
        if (tookDamage < 2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*** Hedgehog in Defense Mode ***");
            tookDamage++;
            Console.ResetColor();
            return;
        }
        Health -= value;
    }
}