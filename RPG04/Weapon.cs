/*Introduce a new abstract class Weapon
Weapon has a read-only Property named Power of type int
And a Constructor that requires a Parameter named power of type int, which is then assigned to the Power-Property
Introduce the following Weapons:
TrainingWeapon with 66 power
BoneSword with 46 power
CursedStaff with 32 power
Unarmed with 0 power
Spike with 27 power
Change the Unit-constructor to not require power of type int anymore
But instead require a weapon of type Weapon
Also, remove the Power-Property of type int from the Unit
And add a Weapon-Property of type Weapon to the Unit instead
Assign the weapon passed to the Unit-constructor to the Unit's Weapon-Property
Assign the following Weapons in the different classes' constructors:
Hero: new TrainingWeapon()
Skeleton: new BoneSword()
Necromancer: new CursedStaff()
Bomb: new Unarmed()
Hedgehog: new Spike()
Modify the Attack-Method, so it does not pass Power into the TakeDamage-Method, but Weapon.Power instead.
Add a new Message to Attacks that looks like this: Unit #3: Hero uses TrainingWeapon to attack Unit #4: Necromancer for 66 Damage.
*/
public abstract class Weapon
{
    private int Power { get; }

    public Weapon(int power)
    {
        Power = power;
    }
}
