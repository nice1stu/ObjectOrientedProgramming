Unit unit = new Unit();
Console.WriteLine(unit.Health);
Player player = new Player("Player1");
//player.Id = "Player1";
Console.WriteLine(player.Id);

public class Unit
{
    private int health;

    public int Health
    {
        get => health;
        private set => health = Math.Max(0, value);
    }
}

public class Circle
{
    public float Radius { get; set; }
}

public class Player
{
    public string Id { get; }

    public Player(string id)
    {
        Id = id;
    }
}