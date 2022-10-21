public abstract class Weapon
{
    public int Power { get; }

    public Weapon(int power)
    {
        this.Power = power;
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