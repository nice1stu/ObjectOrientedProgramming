using System;

namespace RPG05
{
    Unit unit = new Unit("Leet", 1337);

    while (unit.Health > 0)
    {
        Console.WriteLine("Enter a new value for the unit's health:");
        int newHealth = int.Parse(console.ReadLine());
        unit.Health = newHealth;
    }

}
