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
            Console.ResetColor();
            FaceEnemy(target);
            
            if(hero.IsDead)
                break;
        }
        if(!hero.IsDead)
            Console.WriteLine($"{hero} has WON !");

        GameOver();
    }
    
    static void FaceEnemy(Unit target)
    {
        while (!target.IsDead)
        {
            Console.WriteLine("The fight continues... (Press any key.)");
            Console.ReadKey();

            hero.Attack(target);
            if(hero.IsDead)
            {
                OnHeroDeath();
                break;
            }

            if (target.IsDead)
            {
                Console.WriteLine($"{target.Name} is dead");
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
        }
    }
        
    static Unit SpawnRandomEnemy()
    {
        Random random = new Random();
        int number = random.Next(0, 3);
        Console.ForegroundColor = ConsoleColor.Red;
        return number switch
        {
            0 => new Bomb("Bomb", 500, new Unarmed()),
            1 => new Hedgehog("Hedgehog", 200, new Spike(27)),
            2 => new Skeleton("Skeleton", 250, new BoneSword(46)),
            _ => new Necromancer("Necromancer", 300, new CursedStaff(32))
        };

    }
    
    static void OnHeroDeath()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{hero.Name} has Died");
        Console.ResetColor();
        GameOver();
    }
    static void GameOver()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Game Over.");
        Console.ResetColor();
    }
}