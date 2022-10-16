/*Create a Console Project named RPG
Create a class named Unit
Add a field to the Class of type string named name
Add a Constructor to the Class
The Constructor requires an argument of type string named name
Assign the value of name to the field name (use this. to reference the field)
Add a field of type int named id to the Class
Add a static field of type int named nextId to the Class
static fields are shared across all Class instances
In the Constructor, assign the value of nextId to the field id of the class
After that, increase nextId by 1
this ensures, that the next unit gets a higher id than the previous one
Add a method named ReportStatus to the Class
It reports the unit's status to the User by printing:
Unit #2: Zombie
where 2 needs to be replaced by the unit's id
and Zombie needs to be replaced by the unit's name
Create three instances of a Unit with names of your choice
Call ReportStatus at the end of the Constructor!
Make sure, that this Method call stays at the bottom of the constructor at all times!
I think it's best to put a comment there right away: // Make sure, that this is the last line of the constructor:

Continue working on the Project RPG
Add a Finalizer to the Unit Class
Make it say print Unit #2: Zombie got finalized." to the Console.
You can quickly test it using following code sample:

Continue working on the Project RPG
Add two new fields to the Unit Class. Both fields should NOT be accessible from outside the class!
maxHealth of type int
health of type int
Require maxHealth as an argument in the constructor
This phrasing describes two steps:
Adding the parameter to the constructor's parameter list
Assigning the passed value to the class's field in the constructor body
In the Constructor, set health to the same value as maxHealth, too
Modify ReportStatus, to show not only the Id and Name, but also Health and MaxHealth:
Unit #27: Zombie - 127/200 Health
27 is the id
Zombie is the name
127 is the health
200 is the maxHealth
Create a public Method named SetHealth to the Unit-class.
The method takes one argument: newHealth of type int
It then sets the Unit's health to the value of newHealth
It also ensures, that the new health is not smaller than 0 or greater than maxHealth
It then calls ReportStatus to print the new Status to the Console
Test the functionality by:
Creating a Unit with name Leet and maxHealth 1337
Asking the User 3 times, to what value he wants to change the Unit's health
Assign the given value each time to the Unit's SetHealth-Method:

Continue working on the Project RPG
Replace the Method SetHealth with a public Property named Health of type int
The same logic that happened in SetHealth before, should now happen in that Property's set
Add a get to the Property, which returns the current value of the health-field
Change the Game-Loop:
Don't ask the user 3 times for Leet's new Health
But instead ask him for as long as Leet's Health is greater than zero

Change the field name to be a Property named Name which only has a get, but no set
You can still assign the value in the constructor, but nowhere else anymore

Add a property named IsAlive of type bool to the Unit Class
It should have a get that returns true, if health is greater than zero
And false in any other case
In the Game Loop, use this property instead of comparing Health <= 0 or Health > 0!
You can make the Health Property's get protected now!

Introduce a public method named Damage
It returns nothing
It takes a parameter named value of type int
It then subtracts value from our current Health and assigns it to Health
Change the Game Loop, so it does
Not ask anymore, what we want Leet's Health to be
But instead asks, how much damage we want to deal
And then calls the Damage-Method with that value*/

/*string[] enemyNames = new[] { "Zombie", "Skeleton", "Necromancer", "LivingHand", "Leet" };
int[] maxHealthTable = new[] { 100, 200, 300, 400, 1337 };

Unit unit = new Unit(enemyNames[4], maxHealthTable[4]);*/
Necromancer necromancer = new Necromancer("necromancer", 300);
while (necromancer.IsAlive)
{
    Console.WriteLine($"How much damage do you want to deal to {necromancer}?");
    int value = Convert.ToInt32(Console.ReadLine());
    necromancer.Damage(value);
    necromancer.ReportStatus();
}

/*Testing Finalizer
for(int i = 0; i < 2; i++)
{
    Unit unit = new Unit("LivingHand");
    GC.Collect();
}*/