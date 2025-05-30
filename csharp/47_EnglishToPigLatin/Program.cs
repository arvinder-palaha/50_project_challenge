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
        string result = "";
        // if first letter is vowel, add "yay" to the end
        if (Regex.IsMatch(word, @"^[aeiouAEIOU]"))
        {
            result = word + "yay";
        }
        // if first letter is consonant, move it to the end and add "ay"
        else
        {
            bool isCapital = char.IsUpper(word[0]);
            string firstLettersBeforeVowel = Regex.Match(word, @"^[^aeiouAEIOU]+").Value;
            string restOfWord = word.Substring(firstLettersBeforeVowel.Length);

            if (isCapital)
            {
                result = string.Concat(
                    restOfWord[0].ToString().ToUpper(),
                    restOfWord.AsSpan(1).ToString(),
                    firstLettersBeforeVowel[0].ToString().ToLower(),
                    firstLettersBeforeVowel.AsSpan(1).ToString(),
                    "ay"
                );
            }
            else
            {
                result = string.Concat(
                    restOfWord,
                    firstLettersBeforeVowel,
                    "ay"
                );
            }
        }

        return result;
    }

    public static void Printout(MatchCollection words)
    {
        Console.WriteLine(string.Join(", ", words));
    }
}
