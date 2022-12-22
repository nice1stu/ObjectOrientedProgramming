public interface IWeapon
{
    int Power { get; }
    string Name { get; }
    IHand EquippedTo { get; }
    void EquipTo(IHand hand);
    void UnEquip();
}

public abstract class Weapon : IWeapon
{
    public int Power { get; }
    public abstract string Name { get; }
    public IHand EquippedTo { get; private set; }

    public abstract void EquipTo(IHand hand);
    public abstract void UnEquip();

    public Weapon(int power)
    {
        this.Power = power;
    }
}

public class TrainingWeapon : Weapon
{
    public override string Name => "Training Weapon";

    public override void EquipTo(IHand hand)
    {
        base.EquipTo(hand);
    }

    public override void UnEquip()
    {
        base.UnEquip();
    }

    public TrainingWeapon(int power) : base(power) { }
}

public class BoneSword : Weapon
{
    public override string Name => "BoneSword";

    public override void EquipTo(IHand hand)
    {
        base.EquipTo(hand);
    }

    public override void UnEquip()
    {
        base.UnEquip();
    }

    public BoneSword(int power) : base(power) { }
}

public class CursedStaff : Weapon
{
    public override string Name => "CursedStaff";

    public override void EquipTo(IHand hand)
    {
        base.EquipTo(hand);
    }

    public override void UnEquip()
    {
        base.UnEquip();
    }

    public CursedStaff(int power) : base(power) { }
}

public class Unarmed : Weapon
{
    public override string Name => "Unarmed";

    public override void EquipTo(IHand hand)
    {
        base.EquipTo(hand);
    }

    public override void UnEquip()
    {
        base.UnEquip();
    }

    public Unarmed(int power) : base(power) { }
}

public class Spike : Weapon
{
    public override string Name => "Spike";

    public override void EquipTo(IHand hand)
    {
        base.EquipTo(hand);
    }

    public override void UnEquip()
    {
        base.UnEquip();
    }

    public Spike(int power) : base(power) { }
}

public class Haunt : Weapon
{
    public override string Name => "Haunt";

    public override void EquipTo(IHand hand)
    {
        base.EquipTo(hand);
    }

    public override void UnEquip()
    {
        base.UnEquip();
    }

    public Haunt(int power) : base(power) { }
}