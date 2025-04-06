namespace BetterRandom;

public static class RandomExtensions
{
    public static double NextDouble(this Random random, double max = 1)
    {
        return random.NextDouble() * max;
    }
}