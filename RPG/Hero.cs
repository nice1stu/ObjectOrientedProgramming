namespace RPG;

public class Hero : Unit
{
    public Hero(string name, int maxHealth, Weapon weapon) : base(name, maxHealth, weapon) { }

    public override void ReportStatus()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"Hero - {Health}/{MaxHealth} Health");
        Console.ResetColor();
    }
    
    public override void Attack(Unit target)
    {
        if (target.Weapon is MindControl) // Handle MindControl weapon case
        {
            target.Weapon.Attack(this, this); // Reverse the attack
        }
        
        else if(target is Ghost)
        {
            Random random = new Random();
            int chance = random.Next(99);
            Console.WriteLine(chance);
            if (chance < 55)
            {
                Console.WriteLine("The Hero is too scared to attack!");
            }
            
        else
        {
            TakeDamage(target.Weapon.Power, target);
            if (target is Skeleton)
            {
                Health -= (target.Weapon.Power+10);
                Console.WriteLine("The Hero deals 10 extra Damage against the Skeleton's weak Bones!");
            }
        }

    }
}
    public class Hand : IHand
    {
        public IWeapon Weapon {get; set;}
        public void EquippedTo(IWeapon weapon)
        {
            throw new NotImplementedException();
        }
    }
}