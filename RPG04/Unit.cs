/*Rename the Damage-Method to TakeDamage.
Methods should always describe an Action (something that can be done)
And Damage can either be a Verb (to damage) or a Noun (the damage)
TakeDamage more specifically describes, what the method does

Introduce a new Property IsDead of type bool to the Unit
Have it return true, if the Unit is not IsAlive and false, if the unit IsAlive

Add a read-only (only get;) Property Power of type int to the Unit-class.
Require a new parameter in the Unit's constructor: power of type int
Assign the power-argument's value to the Units Power-Property Now, let's make sure, that this power-argument is provided with all Units:
The Hero has 66 power
The Skeleton has 46 power
The Necromancer has 32 power
The Bomb has 0 power
The Hedgehog has 27 power 
Now, let's add an Attack-Method to the Unit, which allows a Unit to Attack any other Unit
Add a new Method with no return type to the Unit class named Attack
Attack takes one parameter named target of type Unit - this will be the Unit that we want to attack.
Within the Attack-Method, we should call TakeDamage on the target-Unit and pass our own Power as an argument. Now, let's first Remove the Part in our Game Loop, where we ask the Player, how much Damage he wants to deal and replace it with the following Code-Sample:

Change the Unit's Method TakeDamage to take a second parameter named attacker of type Unit.
Now, change the Code all over the place, where the TageDamage-Method is invoked and pass this as a second argument.
Like this: unit.TakeDamage(30, this);
Now, in the Hedgehog's TakeDamage Method, if he is in Defense-Mode, let the Hedgehog deal 5 Damage through its Spikes.
Print: "The Hedgehog's Spikes are up and they hurt!"
Call TakeDamage on the attacker-Unit and deal 5 Damage.
What Danger exists right now?
||think about what might happen, if two Hedgehogs in Defense Mode fight each other.||*/

public class Unit
{
    private int id;
    private static int nextId;
    private int health;
    protected int maxHealth;

    public int Health
    {
        get => health;
        set => health = Math.Clamp(value, 0, maxHealth);
    }

    public Weapon Weapon { get; }
    public string Name { get; }
    
    public bool IsDead => health <= 0;

    public Unit(string name, int maxHealth, Weapon weapon)
    {
        this.Name = name;
        this.maxHealth = maxHealth;
        this.Weapon = weapon;
        health = maxHealth;
        id = nextId++;
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"A {Name} has spawned");
        Console.ResetColor();
    }
    
    public virtual void Attack(Unit target)
    {
        TakeDamage(target.Weapon.Power, target);
    }
    
    public virtual void TakeDamage(int value, Unit opponent)
    {
        Health -= value;
        Console.WriteLine($"The {this.Name} has taken {value} points of Damage from {opponent.Name}");
    }

    // Make sure, that this is the last line of the constructor:
    public virtual void ReportStatus()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Unit #{id}: {Name} - {health}/{maxHealth} Health");
        Console.ResetColor();
    }
    
    ~Unit()//Finalizer
    {
        Console.WriteLine($"Unit #{id}: {Name} got finalized.");
    }
}