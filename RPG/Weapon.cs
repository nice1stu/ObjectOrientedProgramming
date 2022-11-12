public abstract class Weapon : IWeapon
{
    public int Power { get; }
    public string Name { get; }

    public IHand EquippedTo
    {
        get { return null; } //The public get Accessor exists, so other classes can also see, what Hand a Weapon is currently equipped to.
        private set //The private set Accessor will be used to change the Hand that the Weapon is currently equipped to
        {
            
        }
    }

    /*public void EquipTo(IHand hand)
    {

    }*/
    public void UnEquip()
    {
        EquippedTo = null; //On EquippedTo-Property, assign null to the Weapon Property
    }

    public Weapon(int power)
    {
        this.Power = power;
    }
}

public class TrainingWeapon : Weapon
{
    public TrainingWeapon(int power) : base(power){}
    public void EquippedTo(){}
    public void Unequip(){}
}

public class BoneSword : Weapon
{
    public BoneSword(int power) : base(power){}
    public void EquippedTo(){}
    public void Unequip(){}
}

public class CursedStaff : Weapon
{
    public CursedStaff(int power) : base(power){}
    public void EquippedTo(){}
    public void Unequip(){}
}

public class Unarmed : Weapon
{
    public Unarmed() : base(0){}
    public void EquippedTo(){}
    public void Unequip(){}
}

public class Spike : Weapon
{
    public Spike(int power) : base(power){}
    public void EquippedTo(){}
    public void Unequip(){}
}

public class Haunt : Weapon
{
    public Haunt(int power) : base(power){}
    public void EquippedTo(){}
    public void Unequip(){}
}