/*The Hedgehog inherits from Unit, has 200 Health, the name Hedgehog and this Special ability:
When hit, he goes into Defense Mode for 2 Rounds
Print Unit #3: Hedgehog went into Defense Mode!
After 2 rounds, he stops being in Defense Mode
Print Unit #3: Hedgehog stopped being into Defense Mode!
While in Defense Mode, the Hedgehog does not take any Damage from the Player
Print Unit #3: Hedgehog was hit while in Defense Mode!*/

public class Hedgehog : Unit
{
    internal static string name = "Hedgehog";
    internal static int maxHealth = 200;
    private int tookDamage;
    public Hedgehog(string name, int maxHealth) : base(name, maxHealth)
    {
    }
    public override void TakeDamage(int value)
    {
        if (tookDamage < 2)
        {
            Console.WriteLine("Hedgehog in Defense Mode");
            tookDamage++;
            return;
        }
        Health -= value;
    }
}