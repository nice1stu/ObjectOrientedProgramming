Circle circle = new Circle();
circle.Radius = 12;
Console.WriteLine(circle.Radius);
Console.WriteLine(circle.Area);

public class Circle
{
    private float radius;
    private float area;

    public float Radius
    {
        get { return radius; }
        set
        {
            radius = value;
            area = value * value * MathF.PI;
        }
    }

    public float Area
    {
        get { return area; }
    }
}