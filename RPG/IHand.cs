public interface IHand // Classes that equip
{
    public IWeapon Weapon { get; set; } //We will use it to keep track of what Weapon is currently equipped to this Hand
    public void EquippedTo(IWeapon weapon)
    {
        weapon.EquipTo(this);
    }
}