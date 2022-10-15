Unit unit = new Unit();
Console.WriteLine(unit.Health);

public class Unit
{
    private int health;

    public int Health
    {
        get => health;
        private set => health = Math.Max(0, value);
    }
}

public class Radius
{
    private float radius;

    public float Area => radius * radius * MathF.PI;
}