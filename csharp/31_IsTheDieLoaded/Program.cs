namespace IsTheDieLoaded;

public class Program
{
    public static void Main(string[] args){}

    public static bool FairDie(int[] rolls, float criticalValue = 11.0705f)
    {
        /// work out expected number of rolls
        float expected = rolls.Sum() / rolls.Length;

        /// work out chi squared
        float chiSquared = rolls.Sum(roll => (roll - expected) * (roll - expected) / expected);

        /// compare chi squared to critical value
        /// return true if chi squared is less than critical value, false otherwise
        return chiSquared < criticalValue;
    }
}

