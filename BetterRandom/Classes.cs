namespace BetterRandom;

public static class RandomExtensions
{
    public static double NextDouble(this Random random, double max = 1)
    {
        return random.NextDouble() * max;
    }
    public static string NextString(this Random random, params string[] words)
    {
        int chose = random.Next(0,4);
        if(words.Length == 0)
        {
            switch(chose)
            {
                case 0:
                return "up";
                case 1:
                return "down";
                case 2:
                return "left";
                case 3:
                return "right";
                default:
                return "";
            }
        }

        if(words.Length == 1)
        {
            return words[0];
        }else
        {
            chose = random.Next(0,words.Length);
            for(int i = 0; i<words.Length; i++)
            {
                if(chose == i)
                {
                    return words[i];
                }
            }
        }
        return Convert.ToString(chose);
    }
    public static bool CoinFlip(this Random random, double probibility = 0.5)
    {
        int returnTrue = Convert.ToInt32(probibility * 100);
        int chosenNumber = random.Next(0,101); //probability is always 0 to 100 so if the proability of getting true is what you put in
        if(returnTrue > chosenNumber)
        {
            return true;
        }else
        {
            return false;
        }
    }
}