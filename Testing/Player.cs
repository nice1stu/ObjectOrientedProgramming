public class Player
{
    public Weapon Weapon { get; private set; }

    public void EquipWeapon(Weapon weapon)
    {
        if (!weapon.isBroken)
        {
            this.Weapon = weapon;
        }
    }

    public void Attack()
    {
        if (this.Weapon == null)
        {
            Console.WriteLine("No Weapon!");
        }
        else
        {
            Console.WriteLine("Attack!");
        }
    }
}