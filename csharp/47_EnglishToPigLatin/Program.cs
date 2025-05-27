namespace EnglishToPigLatin;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("English to Pig Latin Translator");
        if (args.Length > 0)
        {
            Console.WriteLine(Translate(args[0]));
        }
        else
        {
            Console.WriteLine("No input provided");
        }
    }

    public static string Translate(string sentence)
    {
        return sentence;
    }
}
