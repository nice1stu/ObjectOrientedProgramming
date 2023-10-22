namespace RPG;

class Program
{
    private static Unit _hero;
    
    public static void Main(string[] args)
    {
        _hero = new Hero("Hero", 1000, new TrainingWeapon(66));
        
        //Game Controller
        for (int i = 0; i < 3; i++)
        {
            var target = SpawnRandomEnemy();
            FaceEnemy(target);
            
            if(_hero.IsDead)
                break;
        }

        if (!_hero.IsDead)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"{_hero} has WON !");
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

            _hero.Attack(target);
            if(_hero.IsDead)
            {
                OnHeroDeath();
                break;
            }
            
            target.Attack(_hero);
            if(_hero.IsDead)
            {
                OnHeroDeath();
                break;
            }
                
            _hero.ReportStatus();
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
        int number = random.Next(0, 5);
        Console.ForegroundColor = ConsoleColor.Red;
        return number switch
        {
            0 => new Bomb("Bomb", 500, new Unarmed()),
            1 => new Ghost("Ghost", 200, new Haunt(10)),
            2 => new Hedgehog("Hedgehog", 200, new Spike(27)),
            3 => new Skeleton("Skeleton", 250, new BoneSword(46)),
            4 => new Necromancer("Necromancer", 300, new CursedStaff(32)),
            5 => new BigBrain("BigBrain", 100, new MindControl()),
            _ => throw new InvalidOperationException("Invalid number generated")
        };
    }
    
    static void OnHeroDeath()
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"{_hero.Name} has Died");
        Console.ResetColor();
    }
    
    static void GameOver()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Game Over.");
        Console.ResetColor();
    }
}