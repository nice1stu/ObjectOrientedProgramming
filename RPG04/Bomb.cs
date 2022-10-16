/*The Bomb inherits from Unit, has 500 Health, the name Bomb and this Special Ability:
It explodes after 5 Rounds
When exploding, the Bomb's Health is set to 0
Print Unit #3: Bomb has exploded!
Add these three new monsters to your SpawnNewUnit-Method
extend the Random Number to give results between 0 and 2
And map each of these numbers to a Unit that is then created*/

public class Bomb:Unit
{
    internal static string name = "Bomb";
    internal static int maxHealth = 500;

    public Bomb(string name, int maxHealth) : base(name, maxHealth)
    {
    }
    public void SelfDestruct()
    {
        //goes boom ! fater 5 rounds
    }
}