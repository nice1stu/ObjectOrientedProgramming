namespace RPG;

public abstract class Weapon : IWeapon
{
    public int Power { get; }
    public string Name { get; }
    public IHand EquippedTo { get; private set; }
    
    public void EquipTo(IHand hand)
    {
        if (EquippedTo != null)
        {
            EquippedTo.Weapon = null; // Remove from the previously equipped hand
        }

        EquippedTo = hand;
        hand.Weapon = this; // Equip to the new hand
    }

    public void UnEquip()
    {
        if (EquippedTo != null)
        {
            EquippedTo.Weapon = null; // Remove from the equipped hand
            EquippedTo = null;
        }
    }

    public Weapon(int power)
    {
        Power = power;
    }
    
    public void Attack(Unit attacker, Unit target)
    {
        int damage = Power;
        target.TakeDamage(damage, attacker);
    }
}

public class TrainingWeapon : Weapon
{
    public TrainingWeapon(int power) : base(power){}
}

public class BoneSword : Weapon
{
    public BoneSword(int power) : base(power){}
}

public class CursedStaff : Weapon
{
    public CursedStaff(int power) : base(power){}
}

public class Unarmed : Weapon
{
    public Unarmed() : base(0){}
}

public class Spike : Weapon
{
    public Spike(int power) : base(power){}
}

public class Haunt : Weapon
{
    public Haunt(int power) : base(power){}
}

public class MindControl : Weapon
{
    public MindControl() : base(0) { }
    public void Attack(Unit attacker, Unit target)
    {
        Console.WriteLine($"Unit #{attacker.Id}: {attacker.Name} uses {Name} on unit #{target.Id}");
        attacker.TakeDamage(target.Weapon.Power, attacker); // Reverse the attack by damaging the attacker
    }

}



