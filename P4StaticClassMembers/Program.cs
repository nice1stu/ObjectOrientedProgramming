//Create a static class named SuperMath


float from;
float to;
float[] t = { 0f, .1f, .3f, .7f, 1f, 1.3f };

int i;

/*for (int j = 0; j < 3; j++)
{
    for (i = 0; i < 6; i++)
    {
        //from = 0;
        to = 100;
        SuperMath.Lerp(from, to, t[i]);
    }

    from = from + 100;
}*/

for (i = 0; i < 6; i++)
{
    from = 0;
    to = 100;
    SuperMath.Lerp(from, to, t[i]);
}

for (i = 0; i < 6; i++)
{
    from = 100;
    to = 200;
    SuperMath.Lerp(100, 200, t[i]);
}

for (i = 0; i < 6; i++)
{
    from = 200;
    to = -100;
    SuperMath.Lerp(200, -100, t[i]);
}

public static class SuperMath
{
    public static float from;

    public static float to;

    public static float t;
    public static void Lerp(float from, float to, double t)
    {
        float answer = (float)(from + (to - from) * t);
        Console.WriteLine($"Lerp from {from} to {to} with t({t}):{answer}");
    }
}