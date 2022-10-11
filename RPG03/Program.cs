// Lets try the RPG

using RPG03;

Unit unit = new Unit("Skeleton", 100);
unit = new Unit("Zombie", 200);
Necromancer necromancer = new Necromancer("Necromancer",300);
unit = new Unit("Leet", 1337);
int value = 0;

void Damage()
{
    unit.Health -= value;
}

do
{
    Console.WriteLine("How much damage do you want to deal to Leet?");
    string userInput = Console.ReadLine();
    value = Convert.ToInt32(userInput);
    Damage();
} while (unit.IsAlive);