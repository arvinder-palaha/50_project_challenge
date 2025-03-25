namespace MaximumOccurrence;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Maximum Occurrence");
    }

    public static string MaxOccur(string text)
    {
        var charCounts = new Dictionary<char, int>();
        foreach (var c in text)
        {
            if (charCounts.ContainsKey(c))
            {
                charCounts[c]++;
            }
            else
            {
                charCounts[c] = 1;
            }
        }

        var maxOccurrences = charCounts.Values.Max();
        var results = charCounts.Where(kpv => kpv.Value == maxOccurrences)
            .Select(kvp => kvp.Key)
            .OrderBy(c => c)
            .ToArray();

        if (maxOccurrences < 2)
        {
            return "No Repetition";
        }

        return results.Length > 1 ? string.Join(", ", results) : results[0].ToString();
    }
}
