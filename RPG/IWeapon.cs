namespace RPG;

public interface IWeapon
{
    int Power { get; }
    string Name { get; }
    IHand EquippedTo { get; }

    void EquipTo(IHand hand);
    void UnEquip();

    void Attack(Unit attacker, Unit target);
}