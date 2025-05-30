using System.Text.RegularExpressions;

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
        // extract words from sentence using regex
        var words = Regex.Matches(sentence, @"\w+");
        Printout(words);

        // extract the bits in between the words
        var inBetweenWords = Regex.Matches(sentence, @"\W+");
        Printout(inBetweenWords);

        // translate each word
        var translatedWords = words.Select(word => TranslatedWord(word.Value)).ToArray();

        // build the sentence again
        string result = "";
        for (int i = 0; i < words.Count; i++)
        {
            result += translatedWords[i];
            if (i < inBetweenWords.Count)
            {
                result += inBetweenWords[i];
            }
        }
        return result;
    }

    public static string TranslatedWord(string word)
    {
        return word;
    }

    public static void Printout(MatchCollection words)
    {
        Console.WriteLine(string.Join(", ", words));
    }
}
