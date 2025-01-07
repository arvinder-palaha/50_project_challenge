namespace FindTheBomb;

public class Program
{
    public static void Main(string[] args){}

    public static string FindTheBomb(string sentence)
    {
        return sentence.Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";
    }
}
