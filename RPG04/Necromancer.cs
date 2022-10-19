/*Introduce a new class, called Necromancer that inherits from Unit
Add a parameter-less constructor that calls the base-constructor with the proper values
Introduce a bool-field named hasResurrected, so the can keep track on whether the Necromancer has died already.
Make the Damage-Method of the Unit-class virtual
override the Damage-Method in the Necromancer class
Invoke the base-Method, to make sure, that the regular damage-dealing still works
After that, check, whether the Necromancer's Health is zero or less and that he has NOT resurrected, yet
If so: flag hasResurrected to be true, and set his Health to 50% of maxHealth again.
Update the Game Loop, so a Necromancer is spawned instead of Leet

Take the code that ressurects the Necromancer (set the health to 50% and change the flag)
And move it to its own private Method named Resurrect
Call this Method from within the Necromancer's Damage-Method instead of the two lines of code that currently do so*/

public class Necromancer : Unit
{
    internal static string name = "Necromancer";
    internal static int maxHealth = 300;
    //internal static int power = 32;
    public static Weapon weapon { get; }
    bool hasResurrected = false;

    private void HasResurrected()
    {
        if (IsDead && !hasResurrected)
        {
            Console.WriteLine("Necromancer is born again!");
            Health = (int)(maxHealth * .5);
            hasResurrected = true;
        }
    }

    public Necromancer(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon)
    {
        CursedStaff cursedStaff = new CursedStaff();
    }
    public override void TakeDamage(int value)
    {
        Health -= value;
        HasResurrected();
    }
}