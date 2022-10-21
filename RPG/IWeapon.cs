public interface IWeapon // Equipable classes
{
    public int Power { get; } //We will use it to keep track of a Weapon's damage in the Attack method.
    public IHand EquippedTo { get; } //We will use it to keep track of what Hand the Weapon is currently equipped to

    public void EquipTo(IHand hand) //We will use it to equip a Weapon to a new Hand
    {

    }

    public void UnEquip() //We will use it to unequip a weapon from whatever Hand it is currently equipped to.
    {
        
    }
}