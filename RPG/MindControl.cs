namespace RPG;

public class MindControl : IWeapon
{
    public int Power => 0;
    public string Name => "Mind Control";
    public IHand EquippedTo { get; private set; }
    public void EquipTo(IHand hand)
    {
        EquippedTo = hand;
        hand.Weapon = this;
    }

    public void UnEquip()
    {
        // Can't be unequipped
    }

    public void Attack(Unit attacker, Unit target)
    {
        Console.WriteLine($"Unit #{attacker.Id}: {attacker.Name} uses {Name} on unit #{target.Id}");
        target.Attack(target);
    }
}