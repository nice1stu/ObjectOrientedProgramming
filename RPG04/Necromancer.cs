/*Introduce a new class, called Necromancer that inherits from Unit
Add a parameter-less constructor that calls the base-constructor with the proper values
Introduce a bool-field named hasResurrected, so the can keep track on whether the Necromancer has died already.
Make the Damage-Method of the Unit-class virtual
override the Damage-Method in the Necromancer class
Invoke the base-Method, to make sure, that the regular damage-dealing still works
After that, check, whether the Necromancer's Health is zero or less and that he has NOT resurrected, yet
If so: flag hasResurrected to be true, and set his Health to 50% of maxHealth again.
Update the Game Loop, so a Necromancer is spawned instead of Leet*/

public class Necromancer : Unit
{
    bool hasResurrected = false;
    
    public Necromancer(string name, int maxHealth) : base(name, maxHealth){}
    public override void Damage(int value)
    {
        Health -= value;
        if (Health <= 0 && hasResurrected == false)
        {
            Console.WriteLine("I am born again!");
            Health = (int)(maxHealth * .5);
            hasResurrected = true;
        }
    }
}