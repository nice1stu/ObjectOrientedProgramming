class Program
{
    private static Unit hero;
    
    public static void Main(string[] args)
    {
        hero = new Hero("Hero", 1000, new TrainingWeapon(66));
        
        //Game Controller
        for (int i = 0; i < 3; i++)
        {
            var target = SpawnRandomEnemy();
            FaceEnemy(target);
            
            if(hero.IsDead)
                break;
        }

        if (!hero.IsDead)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{hero} has WON !");
            Console.ResetColor();
        }
        GameOver();
    }
    
    static void FaceEnemy(Unit target)
    {
        while (!target.IsDead)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The fight continues... (Press any key.)");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();

            hero.Attack(target);
            if(hero.IsDead)
            {
                OnHeroDeath();
                break;
            }
            
            target.Attack(hero);
            if(hero.IsDead)
            {
                OnHeroDeath();
                break;
            }
                
            hero.ReportStatus();
            target.ReportStatus();
            if (target.IsDead)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{target.Name} is dead");
                Console.ResetColor();
            }
        }
    }
    
    static Unit SpawnRandomEnemy()
    {
        Random random = new Random();
        int number = random.Next(0, 4);
        Console.ForegroundColor = ConsoleColor.Red;
        return number switch
        {
            0 => new Bomb("Bomb", 500, new Unarmed()),
            1 => new Ghost("Ghost", 200, new Haunt(10)),
            2 => new Hedgehog("Hedgehog", 200, new Spike(27)),
            3 => new Skeleton("Skeleton", 250, new BoneSword(46)),
            _ => new Necromancer("Necromancer", 300, new CursedStaff(32))
        };

    }
    
    static void OnHeroDeath()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"{hero.Name} has Died");
        Console.ResetColor();
    }
    
    static void GameOver()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Game Over.");
        Console.ResetColor();
    }
}

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

public interface IHand // Classes that equip
{
    public IWeapon Weapon { get; set; } //We will use it to keep track of what Weapon is currently equipped to this Hand
}
