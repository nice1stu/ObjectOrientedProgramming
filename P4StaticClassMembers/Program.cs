/*Create a Console Project named P4StaticClassMembers
  Create a static class named SuperMath
  In that claas, create a static method named Lerp
  Tt takes three arguments:
  from of type float
  to of type float
  t of type float
  It returns one value of type float:
  It returns the result of the formula from + (to - from)*t*/

float[] t = new float[] { 0f, .1f, .3f, .7f, 1f, 1.3f };
float[] from = new float[] { 0, 100, 200 };
float[] to = new float[] { 100, 200, -100 };

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < t.Length; j++)
    {
        float result = SuperMath.Lerp(from[i], to[i], t[j]);
        Console.WriteLine($"Lerp from {from[i]} to {to[i]} with t({t[j]}): {result}");
    }
}

public static class SuperMath
{
    public static float Lerp(float from, float to, float t)
    {
        float result = from + (to - from) * t;
        return result;
    }
}