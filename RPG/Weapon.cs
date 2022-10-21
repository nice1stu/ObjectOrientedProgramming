public abstract class Weapon : IWeapon
{
    public int Power { get; }

    public IHand EquippedTo
    {
        get { return null; } //The public get Accessor exists, so other classes can also see, what Hand a Weapon is currently equipped to.
        private set //The private set Accessor will be used to change the Hand that the Weapon is currently equipped to
        {
            //On EquippedTo-Property, assign null to the Weapon Property
        }
    }

    public void EquipTo(IHand hand)
    {

    }
    public void UnEquip()
    {
        EquippedTo = null;
    }

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